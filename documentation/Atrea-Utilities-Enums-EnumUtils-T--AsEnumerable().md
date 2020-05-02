#### [Atrea.Utilities](./index.md 'index')
### [Atrea.Utilities.Enums](./Atrea-Utilities-Enums.md 'Atrea.Utilities.Enums').[EnumUtils&lt;T&gt;](./Atrea-Utilities-Enums-EnumUtils-T-.md 'Atrea.Utilities.Enums.EnumUtils&lt;T&gt;')
## EnumUtils&lt;T&gt;.AsEnumerable() Method
Creates and yields an enumerable of the values of the enumerated type.  
```csharp
public static System.Collections.Generic.IEnumerable<T> AsEnumerable();
```
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](./Atrea-Utilities-Enums-EnumUtils-T-.md#Atrea-Utilities-Enums-EnumUtils-T--T 'Atrea.Utilities.Enums.EnumUtils&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Returns an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') of values of the enumerated type.  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Throws argument exception when called on non-enumerated type.  
