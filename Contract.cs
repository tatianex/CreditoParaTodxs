using System;

public class Contract
{
	// CLASSE DO CONTRATO

	// Cada contrato terá um identificador, nome, cliente e oferta
	// cada contrato é gerado a partir da oferta aceita,
	// também terá data, valor, data de início e fim de contrato
	// taxa de juros, valor da parcela, valor total com os juros,
	// e o total de meses que levará para quitar o empréstimo

	string ID { get; set; }
	string Name { get; set; }
	Customer Customer { get; set; }
	Quotation Quotation { get; set; }
	DateTime Date { get; set; }
	decimal Value { get; set; }
	DateTime InitialDate { get; set; }
	DateTime FinalDate { get; set; }
	decimal Tax { get; set; }
	decimal LoanPortionAmount { get; set; }
	decimal Total { get; set; }
	int Months { get; set; }

	public Contract(
		string ID,
		string name,
		Customer customer,
		Quotation quotation,
		DateTime date,
		decimal value,
		DateTime initialDate,
		DateTime finalDate,
		decimal tax,
		decimal loanPortionAmount,
		decimal total,
		int months
	)
	{
		this.ID = ID;
		this.Name = name;
		this.Customer = customer;
		this.Quotation = quotation;
		this.Date = date;
		this.Value = value;
		this.InitialDate = initialDate;
		this.FinalDate = finalDate;
		this.Tax = tax;
		this.LoanPortionAmount = loanPortionAmount;
		this.Total = total;
		this.Months = months;
	}
}
