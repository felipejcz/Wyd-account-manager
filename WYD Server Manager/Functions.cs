using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace WYD_Server_Manager
{
    class Functions : Structs
    {
        public static StructName LoadFile<StructName>(byte[] rawData) where StructName : struct
        {
            var getAlloc = GCHandle.Alloc(rawData, GCHandleType.Pinned);
            try
            {
                var Pointer = getAlloc.AddrOfPinnedObject();
                return (StructName)Marshal.PtrToStructure(Pointer, typeof(StructName));
            }
            finally
            {
                getAlloc.Free();
            }
        }

        public static StructName LoadFile<StructName>(object rawData) where StructName : struct
        {
            var getAlloc = GCHandle.Alloc(rawData, GCHandleType.Pinned);
            try
            {
                var Pointer = getAlloc.AddrOfPinnedObject();
                return (StructName)Marshal.PtrToStructure(Pointer, typeof(StructName));
            }
            finally
            {
                getAlloc.Free();
            }
        }

        public static bool LocalizarContas()
        {

            try
            {
                External.listaContas.Clear();

                DirectoryInfo diretorio = new DirectoryInfo(Environment.CurrentDirectory + @"/account/");
                FileInfo[] files = diretorio.GetFiles(".", SearchOption.AllDirectories);
                
                foreach (FileInfo fileinfo in files)
                {
                    if (fileinfo.Extension == "")//Só pega arquivos sem extensão.
                    {

                        Byte[] data = File.ReadAllBytes(fileinfo.FullName);
                        Structs.STRUCT_ACCOUNTFILE contas;
                        var getAlloc = GCHandle.Alloc(data, GCHandleType.Pinned);
                        try
                        {
                            var Pointer = getAlloc.AddrOfPinnedObject();
                            contas = (Structs.STRUCT_ACCOUNTFILE)Marshal.PtrToStructure(Pointer, typeof(Structs.STRUCT_ACCOUNTFILE));
                        }
                        finally
                        {
                            getAlloc.Free();
                        }

                        External.listaContas.Add(contas);
                        Console.WriteLine(contas.Info.AccountName);

                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public static void LoadAccount(string Patch)
        {
            try
            {
                Byte[] data = File.ReadAllBytes(Patch);
                External.conta = LoadFile<STRUCT_ACCOUNTFILE>(data);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadAccounts(string Patch)
        {
            try
            {
                Byte[] data = File.ReadAllBytes(Patch);
                External.conta = LoadFile<STRUCT_ACCOUNTFILE>(data);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string exportJson(List<Structs.STRUCT_ACCOUNTFILE> contas,string caminho,string checado)
        {
            try
            {
                switch (checado)
                {
                    case "geral":
                        //exporta tudo.
                        break;
                    case "level":
                        //implementar função pra pegar lvl maior de cada conta;
                        break;

                    case "gold":
                        //implementar função pra pegar total de gold e barra de cada conta;
                        break;

                    case "pvp":
                        //implementar função pra pegar killpoint de cada conta;
                        break;
                }
                var json = JsonConvert.SerializeObject(contas);
                File.WriteAllText(caminho, json);
                return "Json exportado com sucesso!";
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao tentar exportar Json: " + error.Message);
                return "Falha ao exportar Json!";
            }

        }

        public static string importJson(string Patch)
        {
            try
            {
                string json = File.ReadAllText(Patch);
                JObject response = JObject.Parse(json);
                External.conta = response.ToObject<STRUCT_ACCOUNTFILE>();
                return "Json importado com sucesso!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "Erro ao importar Json!";
            }

        }

        public static void SaveAccounts()
        {
            foreach(Structs.STRUCT_ACCOUNTFILE conta in External.listaContas)
            {
                Structs.STRUCT_ACCOUNTFILE Account = conta;
                try
                {
                    string DirAccount = Directory.GetCurrentDirectory() + @"/account/" + Account.Info.AccountName[0].ToString();
                    byte[] data = new byte[Marshal.SizeOf(Account)];

                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(Account));
                    Marshal.StructureToPtr(Account, ptr, true);
                    Marshal.Copy(ptr, data, 0, Marshal.SizeOf(Account));
                    Marshal.FreeHGlobal(ptr);
                    bool folderExists = Directory.Exists(DirAccount);
                    if (!folderExists)
                    {
                        MessageBox.Show("Pasta da conta não existe.");
                    }
                    else
                    {
                        DirAccount = DirAccount + "/" + Account.Info.AccountName.ToLower();
                        Console.WriteLine(DirAccount);
                        File.WriteAllBytes(DirAccount, data);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }

        public static bool excluirConta()
        {
            try
            {
                string DirAccount = Directory.GetCurrentDirectory() + @"/account/" + External.listaContas[External.currentChar].Info.AccountName[0].ToString()+"/"+External.listaContas[External.currentChar].Info.AccountName.ToString();
                Console.WriteLine(DirAccount);
                Console.WriteLine(File.Exists(DirAccount));
                if (File.Exists(DirAccount))
                {
                    File.Delete(DirAccount);
                    return true;
                }else
                {
                    MessageBox.Show("Caminho da conta não encontrado.");
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao tentar excluir conta: " + error.Message);
                return false;
            }
            return false;
        }

        public static bool CheckSpecialCaracters(string Text)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (Text.Contains(item))
                    return true;
            }
            return false;
        }
    }
}
