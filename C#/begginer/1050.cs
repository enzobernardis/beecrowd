using System; 

class URI {

  static void Main(string[] args) { 
    string result = "";
    switch(Console.ReadLine()) {
      case "61": result = "Brasilia"; break;
      case "71": result = "Salvador"; break;
      case "11": result = "Sao Paulo"; break;
      case "21": result = "Rio de Janeiro"; break;
      case "32": result = "Juiz de Fora"; break;
      case "19": result = "Campinas"; break;
      case "27": result = "Vitoria"; break;
      case "31": result = "Belo Horizonte"; break;
      default: result = "DDD nao cadastrado"; break;
    }

    Console.WriteLine(result);
  }

}
