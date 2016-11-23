using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Nutricao
{
	public partial class ListaRefeicoes : ContentPage
	{
		public ObservableCollection<Refeicao> Refeicoes { get; set; }

		public ListaRefeicoes(ObservableCollection<Refeicao> refeicoes)
		{
			BindingContext = this;
			Refeicoes = refeicoes;
			InitializeComponent();
		}

		public async void AcaoItem(object sender, ItemTappedEventArgs e)
		{
			Refeicao refeicao = e.Item as Refeicao;
			var resposta = await DisplayAlert("Remover Refeição", "Você tem certeza que deseja emover a refeição " + refeicao.Descricao, "Sim", "Não");

			if (resposta)
			{
				Refeicoes.Remove(refeicao);
				await DisplayAlert("Remover Refeição", "Refeição removida com sucesso!", "OK");
			}


		}
	}
}
