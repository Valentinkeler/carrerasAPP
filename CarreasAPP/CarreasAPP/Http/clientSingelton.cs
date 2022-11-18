using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreasAPP.Http
{
    class clientSingelton
    {
        public static clientSingelton instancia;
        public HttpClient client;

        public clientSingelton()
        {
            client = new HttpClient();
        }

        public static clientSingelton getInstance()
        {
            if (instancia==null)
            {
                instancia = new clientSingelton();
            }
            return instancia;
        }

        public  async  Task<string> GetAsync(string url)
        {
            var  result  = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();  
            return  content;
          
        }
        public  async   Task<string>  postAsync(string url,string data)
        {
            StringContent content = new StringContent(data,Encoding.UTF8,"aplication/json");
            var result =   await  client.PostAsync(url,content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;       
        }  
    }
}
