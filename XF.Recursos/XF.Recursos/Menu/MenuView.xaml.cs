using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.App_Code;
using XF.Recursos.Controles;

namespace XF.Recursos.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
        public ListView ListView => lstMenu;
        public MenuView()
        {
            InitializeComponent();

            ObservableCollection<OpcoesMenu> menuItems = new ObservableCollection<OpcoesMenu>
            {
                new OpcoesMenu
                {
                    Descricao = "Home",
                    Icone = "Home.png",
                    TargetType = typeof(HomeView)
                },
                new OpcoesMenu
                {
                    Descricao = "Editor",
                    TargetType = typeof(EditorView)
                },
                new OpcoesMenu
                {
                    Descricao = "Controle de Data",
                    TargetType = typeof(PickerView)
                },
                new OpcoesMenu
                {
                    Descricao = "List Picker",
                    TargetType = typeof(ListPickerView)
                },
                new OpcoesMenu
                {
                    Descricao = "Stepper",
                    TargetType = typeof(StepperView)
                },
                new OpcoesMenu
                {
                    Descricao = "Controle de Progresso",
                    TargetType = typeof(ProgressoView)
                }
            };

            lstMenu.ItemsSource = menuItems;
        }
    }
}