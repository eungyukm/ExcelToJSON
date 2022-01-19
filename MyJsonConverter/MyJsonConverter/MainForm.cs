using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyJsonConverter
{
    public partial class MainForm : Form
    {
        public List<FileManager> FileManagerList;
        public List<Button> DeleteButtons;
        public List<Button> FindButtons;
        public List<CheckBox> CheckBoxes;
        public List<TextBox> InputTexts;
        public List<TextBox> NewTexts;
        public List<Label> FirstLabels;
        public List<Label> SecondLabels;

        public MainForm()
        {
            FileManagerList = new List<FileManager>();

            DeleteButtons = new List<Button>();
            FindButtons = new List<Button>();
            CheckBoxes = new List<CheckBox>();
            InputTexts = new List<TextBox>();
            NewTexts = new List<TextBox>();
            FirstLabels = new List<Label>();
            SecondLabels = new List<Label>();

            InitializeComponent();

            DeleteButtons.Add(DeleteButton);
            FindButtons.Add(FindButton);
            CheckBoxes.Add(MakingCheck);
            InputTexts.Add(FilePathTextBox);
            NewTexts.Add(NewFIleTextBox);
            FirstLabels.Add(FilePathLabel);
            SecondLabels.Add(NewFileLabel);

        }

        private void FindPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            string fullPath = dialog.FileName;
            string fileName = dialog.SafeFileName;
            //파일을 가져왔을 때만.
            if (!string.IsNullOrEmpty(fullPath))
            {
                int index = FindButtons.IndexOf(sender as Button);

                if (InputTexts.Find(x => x.Text == fullPath) != null)
                {
                    MessageBox.Show("이미 같은 파일이 있습니다.", "불가능!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }

                else
                    InputTexts[index].Text = fullPath;
            }
        }

        private void CovertButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "변환 시작!!! 로딩중.....";

            var checkList = new List<bool>();

            for (int i = 0; i < InputTexts.Count; i++)
            {
                TextBox text = InputTexts[i];


                if (!string.IsNullOrEmpty(text.Text))
                {
                    //입력이 있다면.
                    checkList.Add(CheckBoxes[i].Checked);
                    var fileManager = new FileManager();
                    fileManager.FileFullPath = text.Text;
                    if (!string.IsNullOrEmpty(NewTexts[i].Text))
                        fileManager.NewFileName = NewTexts[i].Text;
                    fileManager.NewFileExtension = ".json";
                    FileManagerList.Add(fileManager);
                }
            }

            if(FileManagerList.Count < 1)
            {
                MessageBox.Show("변환할 파일이 없습니다.", "아이고...", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                ResultTextBox.Text = "변환 준비중...";
                return;
            }
            //

            ExcelReader.Init();
            foreach (var manager in FileManagerList)
            {
                ExcelReader.AddExcelFile(manager.FileFullPath);
            }

            //엑셀파일 저장.
            var allSheetsValues = ExcelReader.GetAllSheetValues();
            for(int i = 0; i < allSheetsValues.Count; i++)
            {
                string sheetText = JsonChanger.ChangToJArrayToString(ExcelReader.InfoList[i].DataNames, allSheetsValues[i]);
                FileManagerList[i].SaveNewFile(sheetText);
                if (checkList[i])
                {
                    ClassMaker maker = new ClassMaker(FileManagerList[i].NewFileFullPath);
                    maker.AddField(ExcelReader.InfoList[i].DataNames, ExcelReader.InfoList[i].DataTypeCodes);
                    maker.GenerateCSharpCode();
                }
            }
            FileManagerList.Clear();
            ExcelReader.Free();

            ResultTextBox.Text = "변환이 완료되었습니다!!!";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            int index = DeleteButtons.IndexOf(sender as Button);
            if(index != 0)
            {
                Label firstLabel = FirstLabels[index];
                Label secondLabel = SecondLabels[index];
                TextBox inputText = InputTexts[index];
                TextBox newText = NewTexts[index];
                Button findButton = FindButtons[index];
                Button deleteButton = DeleteButtons[index];
                CheckBox csCheck = CheckBoxes[index];

                this.Controls.Remove(firstLabel);
                this.Controls.Remove(secondLabel);
                this.Controls.Remove(inputText);
                this.Controls.Remove(newText);
                this.Controls.Remove(findButton);
                this.Controls.Remove(deleteButton);
                this.Controls.Remove(csCheck);

                FirstLabels.Remove(firstLabel);
                SecondLabels.Remove(secondLabel);
                InputTexts.Remove(inputText);
                NewTexts.Remove(newText);
                FindButtons.Remove(findButton);
                DeleteButtons.Remove(deleteButton);
                CheckBoxes.Remove(csCheck);

                AddFileButton.Location = new Point(AddFileButton.Location.X, AddFileButton.Location.Y - 30);
                DirectoryButton.Location = new Point(DirectoryButton.Location.X, DirectoryButton.Location.Y - 30);


                for (int i = index; i < FirstLabels.Count; i++)
                    FirstLabels[i].Location = new Point(FirstLabels[i-1].Location.X, FirstLabels[i-1].Location.Y + 30);
                for (int i = index; i < SecondLabels.Count; i++)
                    SecondLabels[i].Location = new Point(SecondLabels[i - 1].Location.X, SecondLabels[i - 1].Location.Y + 30);
                for (int i = index; i < FindButtons.Count; i++)
                    FindButtons[i].Location = new Point(FindButtons[i - 1].Location.X, FindButtons[i - 1].Location.Y + 30);
                for (int i = index; i < DeleteButtons.Count; i++)
                    DeleteButtons[i].Location = new Point(DeleteButtons[i - 1].Location.X, DeleteButtons[i - 1].Location.Y + 30);
                for (int i = index; i < InputTexts.Count; i++)
                    InputTexts[i].Location = new Point(InputTexts[i - 1].Location.X, InputTexts[i - 1].Location.Y + 30);
                for (int i = index; i < NewTexts.Count; i++)
                    NewTexts[i].Location = new Point(NewTexts[i - 1].Location.X, NewTexts[i - 1].Location.Y + 30);
                for (int i = index; i < CheckBoxes.Count; i++)
                    CheckBoxes[i].Location = new Point(CheckBoxes[i - 1].Location.X, CheckBoxes[i - 1].Location.Y + 30);
            }
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if (FirstLabels.Count < 10)
            {
                Button addBtn = AddFileButton;
                addBtn.Location = new Point(addBtn.Location.X, addBtn.Location.Y + 30);
                DirectoryButton.Location = new Point(DirectoryButton.Location.X, DirectoryButton.Location.Y + 30);

                //첫번째 레이블 생성.
                Label first = new Label();
                Label lastLabel = FirstLabels.Last();
                first.Text = lastLabel.Text;
                first.Size = lastLabel.Size;
                first.Font = lastLabel.Font;
                first.Location = new Point(lastLabel.Location.X, lastLabel.Location.Y + 30);
                FirstLabels.Add(first);
                this.Controls.Add(first);

                //세컨드 레이블 생성.
                Label second = new Label();
                lastLabel = SecondLabels.Last();
                second.Text = lastLabel.Text;
                second.Size = lastLabel.Size;
                second.Font = lastLabel.Font;
                second.Location = new Point(lastLabel.Location.X, lastLabel.Location.Y + 30);
                SecondLabels.Add(second);
                this.Controls.Add(second);

                //텍스트1 생성.
                TextBox input = new TextBox();
                TextBox lastText = InputTexts.Last();
                input.Size = lastText.Size;
                input.Font = lastText.Font;
                input.Location = new Point(lastText.Location.X, lastText.Location.Y + 30);
                input.ReadOnly = true;
                InputTexts.Add(input);
                this.Controls.Add(input);

                //텍스트2 생성
                TextBox newText = new TextBox();
                lastText = NewTexts.Last();
                newText.Size = lastText.Size;
                newText.Font = newText.Font;
                newText.Location = new Point(lastText.Location.X, lastText.Location.Y + 30);
                NewTexts.Add(newText);
                this.Controls.Add(newText);

                //찾기 버튼 생성
                Button findButton = new Button();
                Button lastButton = FindButtons.Last();
                findButton.Font = lastButton.Font;
                findButton.Size = lastButton.Size;
                findButton.Location = new Point(lastButton.Location.X, lastButton.Location.Y + 30);
                findButton.Text = lastButton.Text;
                findButton.UseVisualStyleBackColor = true;
                findButton.Click += new System.EventHandler(this.FindPathButton_Click);
                FindButtons.Add(findButton);
                this.Controls.Add(findButton);

                //삭제 버튼 생성.
                Button deleteButton = new Button();
                lastButton = DeleteButtons.Last();
                deleteButton.Font = lastButton.Font;
                deleteButton.Size = lastButton.Size;
                deleteButton.Location = new Point(lastButton.Location.X, lastButton.Location.Y + 30);
                deleteButton.Text = lastButton.Text;
                deleteButton.UseVisualStyleBackColor = true;
                deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
                DeleteButtons.Add(deleteButton);
                this.Controls.Add(deleteButton);

                //체크박스 생성.
                CheckBox csCheck = new CheckBox();
                CheckBox lastCheck = CheckBoxes.Last();
                csCheck.Font = lastCheck.Font;
                csCheck.Size = lastCheck.Size;
                csCheck.Location = new Point(lastCheck.Location.X, lastCheck.Location.Y + 30);
                csCheck.Text = lastCheck.Text;
                CheckBoxes.Add(csCheck);
                this.Controls.Add(csCheck);

            }
        }

        private void DirectoryButton_click(object sender, EventArgs e)
        {
            TextBox text = InputTexts.Find(x => !string.IsNullOrEmpty(x.Text));
            if (text == null) {
                MessageBox.Show("열 위치가 없습니다.", "네버...", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                return;
            }

            string path = text.Text.Substring(0, text.Text.LastIndexOf('\\'));
            System.Diagnostics.Process.Start(path);
        }

        private void MyText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
