using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.CodeDom;
using Microsoft.CSharp;
using System.Reflection;
using System.IO;

namespace MyJsonConverter
{
    public class ClassMaker
    {
        public string FileFullPath;
        public CodeCompileUnit TargetUnit;
        public CodeTypeDeclaration TargetClass;
        public CodeNamespace TargetNameSpace;

        public ClassMaker(string fileFullPath)
        {
            this.FileFullPath = fileFullPath;
            this.SetFileName();

            TargetUnit = new CodeCompileUnit();
            TargetNameSpace = new CodeNamespace("Program");
            string className = FileFullPath.Substring(
                FileFullPath.LastIndexOf('\\') + 1);
            className = className.Substring(0, className.LastIndexOf('.'));
            TargetClass = new CodeTypeDeclaration(className);
            TargetNameSpace.Imports.Add((new CodeNamespaceImport("System")));
            TargetNameSpace.Imports.Add((new CodeNamespaceImport("System.Collections.Generic")));
            TargetNameSpace.Imports.Add((new CodeNamespaceImport("System.Linq")));
            TargetNameSpace.Imports.Add((new CodeNamespaceImport("System.Text")));
            TargetClass.IsClass = true;
            TargetClass.TypeAttributes = TypeAttributes.Public;

            TargetNameSpace.Types.Add(TargetClass);
            TargetUnit.Namespaces.Add(TargetNameSpace);
        }

        private void SetFileName()
        {
            if (this.FileFullPath.Contains('.'))
                FileFullPath = FileFullPath.Substring(0, FileFullPath.LastIndexOf('.'));
            FileFullPath = FileFullPath + ".cs";
        }

        public void AddField(List<string> fieldName, List<TypeCode> typeCodes)
        {
            for (int i = 0; i < typeCodes.Count; i++)
            {
                CodeMemberField field = new CodeMemberField();
                field.Attributes = MemberAttributes.Public;
                field.Name = fieldName[i];
                field.Type = new CodeTypeReference(DataTypeChanger.TypeCodeToType(typeCodes[i]));
                this.TargetClass.Members.Add(field);
            }
        }

        public void GenerateCSharpCode()
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CodeGeneratorOptions option = new CodeGeneratorOptions();
            option.BracingStyle = "C";
            using (StreamWriter sourceWriter = new StreamWriter(FileFullPath))
            {
                provider.GenerateCodeFromCompileUnit(
                    TargetUnit, sourceWriter, option);
            }
        }

    }
}
