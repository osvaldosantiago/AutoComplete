/// <summary>
/// Osvaldo Santiago Estrada
/// Desarrollador de Software
/// osvaldo-santiago@hotmail.com
/// </summary>
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AutoComplete
{
	[Activity (Label = "AutoComplete", MainLauncher = true)]
	public class MainActivity : Activity
	{
		//Fuente de datos de donde se autocompletara el control
		static string[] ESTADOS = new string[] {
			"Aguascalientes","Morelos","Baja California","Nayarit",
			"Baja California Sur","Nuevo León",	"Monterrey",
			"Campeche","Oaxaca",	"Coahuila","Puebla",
			"Colima","Querétaro","Chiapas","Quintana Roo",
			"Chihuahua","San Luis Potosí","Distrito Federal","Ciudad de México","Sinaloa",
			"Durango","Sonora","Guanajuato","Tabasco",
			"Guerrero","Tamaulipas","Hidalgo","Tlaxcala",
			"Jalisco",	"Veracruz","México","Yucatán",
			"Michoacán","Zacatecas"
		};

		//Metodo principal de la aplicacion
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
			//Creamos la instancia de nuestro control declarado en el layout
			AutoCompleteTextView textView = FindViewById<AutoCompleteTextView> (Resource.Id.autoCompleteTextView1);

			var adapter = new ArrayAdapter<String> (this, Resource.Layout.list_item, ESTADOS);
			textView.Adapter = adapter;
		}
	}
}


