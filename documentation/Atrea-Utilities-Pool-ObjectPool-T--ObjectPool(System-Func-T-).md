#### [Atrea.Utilities](./index.md 'index')
### [Atrea.Utilities.Pool](./Atrea-Utilities-Pool.md 'Atrea.Utilities.Pool').[ObjectPool&lt;T&gt;](./Atrea-Utilities-Pool-ObjectPool-T-.md 'Atrea.Utilities.Pool.ObjectPool&lt;T&gt;')
## ObjectPool(System.Func&lt;T&gt;) Constructor
An object pool which efficiently handles retrieving and adding objects to the pool.  
```csharp
public ObjectPool(System.Func<T> objectGenerator);
```
#### Parameters
<a name='Atrea-Utilities-Pool-ObjectPool-T--ObjectPool(System-Func-T-)-objectGenerator'></a>
`objectGenerator` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](./Atrea-Utilities-Pool-ObjectPool-T-.md#Atrea-Utilities-Pool-ObjectPool-T--T 'Atrea.Utilities.Pool.ObjectPool&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The object generator for generating new objects when the pool is empty.  
  
