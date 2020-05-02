#### [Atrea.Utilities](./index.md 'index')
### [Atrea.Utilities.Random](./Atrea-Utilities-Random.md 'Atrea.Utilities.Random').[IRandom](./Atrea-Utilities-Random-IRandom.md 'Atrea.Utilities.Random.IRandom')
## IRandom.Next(int) Method
Returns a non-negative random integer that is less than the specified maxValue.  
```csharp
int Next(int maxValue);
```
#### Parameters
<a name='Atrea-Utilities-Random-IRandom-Next(int)-maxValue'></a>
`maxValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The exclusive upper bound of the random number to be generated. maxValue must be greater than or  
equal to 0.  
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') that is greater than or equal to 0, and less than maxValue.  
