using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LibVLCSharp.Shared;

namespace Ultrakill_RPG;

public partial class MainWindow : Window
{
    private LibVLC? _libVlC;
    private MediaPlayer? _mediaPlayer;
    private Media? _media;
    public MainWindow()
    {
        InitializeComponent();
    }

    protected override void OnOpened(EventArgs e)
    {
        base.OnOpened(e);
        
        if (Design.IsDesignMode) return;
        
        Core.Initialize();
        _libVlC = new LibVLC();
        _mediaPlayer = new MediaPlayer(_libVlC);
        _media = new Media(_libVlC, "/home/kaloyan/koko_programing/Ultrakill_RPG/Ultrakill_RPG/Ultrakill_RPG/Assets/Audio/test.mp3", FromType.FromPath);
        _media.AddOption(":input-repeat=65535");
        //_mediaPlayer.Play(_media);
    }

    protected override void OnClosing(WindowClosingEventArgs e)
    {   
        base.OnClosing(e);
        
        if (Design.IsDesignMode) return;
        
        _mediaPlayer?.Stop();
        _media?.Dispose();
        _mediaPlayer?.Dispose();
        _libVlC?.Dispose();
    }
}