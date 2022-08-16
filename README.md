# CoreSharp
is a small C# library containing helper functions and utilites.
This core library is used in most of our .Net libraries.

# Nuget
Get the latest version from nuget.org<br>
[![NuGet](https://img.shields.io/nuget/v/RCoreSharp.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/RCoreSharp/)
[![NuGet](https://img.shields.io/nuget/dt/RCoreSharp.svg)](https://www.nuget.org/packages/RCoreSharp)

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
