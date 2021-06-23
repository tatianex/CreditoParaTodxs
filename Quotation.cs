using System;
using System.Collections.Generic;

public class Quotation
{
	// CLASSE DE OFERTA DE EMPRÉSTIMO

	// O ID é criado para ser usado nos métodos, 
	// Cada oferta também terá um nome
	// Cada oferta terá um cliente
	// Também é necessário informar o valor, a data,
	// o prazo de pagamento, os juros, o valor da parcela, o valor total com os juros
	// e o número de meses que levará para quitar o empréstimo

	string ID { get; set; }
	string Name { get; set; }
	Customer Customer { get; set; }
	decimal Value { get; set; }
	DateTime Date { get; set; }
	int DeadlineForPayment { get; set; }
	decimal Tax { get; set; }
	decimal LoanPortionAmount { get; set; }
	decimal Total { get; set; }
	int Months { get; set; }


	// Lista as ofertas que estão disponíveis no momento.
	public List<Quotation> List() { }

	// Passando o identificador da oferta como parâmetro
	// retorna os detalhes da mesma.
	public Quotation Detail(string ID) { }

	// Passando o identificador da oferta como parâmetro
	// retorna um booleano true se o cliente contratar
	// e false caso desista da oferta
	public bool Review(string ID) { }

	// Passando o identificador da oferta como parâmetro
	// retorna um booleano true se o cliente assinou o contrato
	// e false caso não tenha fechado o contrato
	public bool SignLoan(string ID) { }

	public Quotation(
		string ID,
		string name,
		Customer Customer,
		decimal value,
		DateTime date,
		int deadlineForPayment,
		decimal tax,
		decimal loanPortionAmount,
		decimal total,
		int months
	)
	{
		this.ID = ID;
		this.Name = name;
		this.Customer = Customer;
		this.Value = value;
		this.Date = date;
		this.DeadlineForPayment = deadlineForPayment;
		this.Tax = tax;
		this.LoanPortionAmount = loanPortionAmount;
		this.Total = total;
		this.Months = months;
	}
}
