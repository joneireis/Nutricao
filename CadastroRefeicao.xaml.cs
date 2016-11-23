using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Nutricao
{
	public partial class CadastroRefeicao : ContentPage
	{
		public ObservableCollection<Refeicao> Refeicoes { get; set; }

		public CadastroRefeicao(ObservableCollection<Refeicao> refeicoes)
		{
			Refeicoes = refeicoes;
			InitializeComponent();
		}

		public void AtualizaContador(Object sender, EventArgs e)
		{
			double valor = stpCalorias.Value;
			lblCalorias.Text = $"{valor:0.00}";
		}
		public void salvaRefeicao(Object sender, EventArgs e)
		{
			string descricao = entDescricao.Text;
			double valor = stpCalorias.Value;

			Refeicao refeicao = new Refeicao(descricao, valor);
			Refeicoes.Add(refeicao);

			DisplayAlert("Salvar Refeição", "A refeição " + descricao + " de " + $"{valor:0.00}" + " caloliras foi sala com sucesso!!!", "OK");

			Clear();
		}
		public void Clear()
		{
			entDescricao.Text = "";
			stpCalorias.Value = 0;
				
		}
		public void MostraLista(Object sender, EventArgs e)
		{
			//ListaRefeicoes tela = new ListaRefeicoes();
			//Navigation.PushAsync(tela);
		}

	}
}
