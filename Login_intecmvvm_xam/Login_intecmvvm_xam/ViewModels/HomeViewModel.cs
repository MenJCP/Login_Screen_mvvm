using Login_intecmvvm_xam.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Login_intecmvvm_xam.ViewModels
{
    public class HomeViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption Ubicacion { get; set; } = new MenuOption();
        public MenuOption Autocaravana { get; set; } = new MenuOption();
        public MenuOption globo { get; set; } = new MenuOption();
        public MenuOption maleta { get; set; } = new MenuOption();
        public MenuOption mapa { get; set; } = new MenuOption();

        public HomeViewModel()
        {
            BarAndHotelsMenuOption.Title = "Hogar";
            BarAndHotelsMenuOption.Image = "casa";

            Ubicacion.Title = "Ubicacion";
            Ubicacion.Image = "ubicacion";

            Autocaravana.Title = "Auto Caravana";
            Autocaravana.Image = "autocaravana";

            globo.Title = "Globo";
            globo.Image = "globo";

            maleta.Title = "Maleta";
            maleta.Image = "maleta";

            mapa.Title = "Mapa";
            mapa.Image = "mapa";
        }
    }
}
