using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace Ultrakill_RPG;

public partial class GameSetupUserControl : UserControl
{
    public GameSetupUserControl() => InitializeComponent();

    private void OnRandomClicked(object? sender, RoutedEventArgs e)
    {
        List<String> enemyNames = new List<string>();
        foreach (GameObject enemy in EnemyList.enemies)
        {
            enemyNames.Add(enemy.GetName());
        }

        EnemyInput.Text = string.Join(" ", enemyNames);
        Texterer.EnemyCreatorRandom(); 
    }

    private void OnStartClicked(object? sender, RoutedEventArgs e)
    {
        //Handle player input
        string playerInput = PlayersInput.Text;
        string[] players = playerInput.Split(' ');
        foreach (string player in players)
        {
            PlayerCreator.PlayerDeclarator(player, 1);
        }
    }
}