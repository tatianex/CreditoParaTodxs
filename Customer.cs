using System;

public class Customer
{
	// CLASSE CLIENTE

	// Cada cliente terá um identificador, um nome, sobrenome, cpf
	// telefone e endereço, precisará informar também a empresa onde trabalha,
	// o cargo que ocupa, seu salário e seu score no Serasa

	string ID { get; set; }
	string Name { get; set; }
	string LastName { get; set; }
	string CPF { get; set; }
	string Telephone { get; set; }
	string Address { get; set; }
	string Company { get; set; }
	string Office { get; set; }
	int Income { get; set; }
	int Score { get; set; }

	public Customer(
		string ID,
		string name,
		string lastName,
		string CPF,
		string telephone,
		string address,
		string company,
		string office,
		int income,
		int score
	)
	{
		this.ID = ID;
		this.Name = name;
		this.LastName = lastName;
		this.CPF = CPF;
		this.Telephone = telephone;
		this.Address = address;
		this.Company = company;
		this.Office = office;
		this.Income = income;
		this.Score = score;
	}
}
