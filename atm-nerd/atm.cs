using System;

class Program {

	static int conta = 3883, senha = 3883;
	
	static void Main(string[] args) {

		inicio:

		Console.WriteLine("Bem vindo ao ATM. "+
			"Pressione ENTER para continuar");
		Console.ReadLine();

		if (ContaConf() && SenhaConf()) {
			Console.WriteLine("Login efetuado com sucesso. ");
		} else {
			Console.WriteLine("Credenciais incorretas. Saindo... ");
			goto inicio;
		}
	}


	static bool ContaConf() {

		Console.Write("Indique a conta: ");
		int valor = Convert.ToInt32(Console.ReadLine());

		if (valor == conta) {
			Console.WriteLine("Conta encontrada. ");
			return true;
		} else {
			Console.WriteLine("Conta não consta em nosso cadastro. ");
			return false;
		}
	}

	static bool SenhaConf() {

		Console.Write("Insira sua senha: ");
		int valor = Convert.ToInt32(Console.ReadLine());

	if (valor == senha) {
		Console.WriteLine("Senha correta. ");
		return true;
	} else {
		Console.WriteLine("Senha incorreta. ");
		return false;
	}
		
		return valor == senha;
	}
}