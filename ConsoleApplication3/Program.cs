using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            //int x = 3;
            //object o = x;
            //x = 4;
            //alteraObjeto(o);
            //int y = (int)o;


            var client = new RestClient("http://localhost:12295");
            //var request = new RestRequest("api/security/token", Method.POST);

            var request = new RestRequest("api/account", Method.POST);

            request.AddHeader("Content-Type", "application/json");

            UsuarioModel usuario = new UsuarioModel();
            usuario.Name = "Maria lemos";
            usuario.Email = "maria.lemos@globo.com";
            usuario.Password = "vacaloca171";
            usuario.ConfirmPassword = "vacaloca171";


            request.AddJsonBody(usuario);


                     
            
            //request.AddParameter("grant_type", "password");
            //request.AddParameter("username", "yasmin.castro@gmail.com");
            //request.AddParameter("password", "vacaloca172");

            IRestResponse<UsuarioModel> response = client.Execute<UsuarioModel>(request);

            if (response.ResponseStatus == ResponseStatus.Completed)
                System.Console.WriteLine("Cadastro efetuado com sucesso");
            else
                System.Console.WriteLine("Ocorreu um erro na operação do cadastramento. " + response.Content);



            //System.Console.WriteLine("Token" + response.Data.access_token);




            System.Console.ReadLine();

            
           

        }


        public static void alteraObjeto(object obj)
        {
            obj = 7;
            

        }

    }
}
