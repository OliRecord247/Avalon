using Avalon.MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalon.MVVM.ViewModels;

public partial class ToDoItemViewModel : ViewModelBase
{
    [ObservableProperty]
    public bool _isChecked;
    
    [ObservableProperty]
    public string? _content;

    public ToDoItemViewModel()
    {
        
    }
    
    public ToDoItemViewModel(TodoItem item)
    {
        IsChecked = item.IsChecked;
        Content = item.Content;
    }
    
    public TodoItem GetToDoItem()
    {
        return new TodoItem()
        {
            IsChecked = this.IsChecked,
            Content = this.Content
        };
    }
}