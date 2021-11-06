# CoreSharp
is a small C# library containing helper functions and utilites.
This core library is used in most of our .Net libraries.

# Usage


## BaseModel
The `BaseModel` can be inherit by any Model/ViewModel.

```cs
public class MyModel : BaseModel
{
    bool _isSearching = false;
    public bool IsSearching
    {
        get => _isSearching;
        set
        {
            if (_isSearching == value)
                return;
            _isSearching = value;
            OnPropertyChanged();
        }
    }
}
```
