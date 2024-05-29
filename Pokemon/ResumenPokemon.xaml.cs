using Pokemon.Models;
using Pokemon.Servicios;
using System.Diagnostics;

namespace Pokemon;

public partial class ResumenPokemon : ContentPage
{

	CaracteristicasPokemon caracteristicas1 = new CaracteristicasPokemon();

	public ResumenPokemon(string url)
	{

		InitializeComponent();
		CargaPokemon(url);
		
	}


	public async void CargaPokemon(string url)
	{
		PokemonApis pokemonApis = new PokemonApis();
		CaracteristicasPokemon caracteristicas = await pokemonApis.DevuelveCaracteristicas(url);
		
		ImagePokemon.Source = caracteristicas.Sprites.front_default;
		habilidades.Text = caracteristicas.Abilities.ToString();

	}
}