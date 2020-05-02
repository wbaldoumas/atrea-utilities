#### [Atrea.Utilities](./index.md 'index')
### [Atrea.Utilities.Random](./Atrea-Utilities-Random.md 'Atrea.Utilities.Random').[IThreadLocalRandomBuilder](./Atrea-Utilities-Random-IThreadLocalRandomBuilder.md 'Atrea.Utilities.Random.IThreadLocalRandomBuilder')
## IThreadLocalRandomBuilder.WithGeneratorValueFactory(System.Func&lt;Atrea.Utilities.Random.IRandom&gt;) Method
Specifies how the thread-safe random number generator should be created by the builder.  
```csharp
Atrea.Utilities.Random.IThreadLocalRandomBuilder WithGeneratorValueFactory(System.Func<Atrea.Utilities.Random.IRandom> generatorValueFactory);
```
#### Parameters
<a name='Atrea-Utilities-Random-IThreadLocalRandomBuilder-WithGeneratorValueFactory(System-Func-Atrea-Utilities-Random-IRandom-)-generatorValueFactory'></a>
`generatorValueFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[IRandom](./Atrea-Utilities-Random-IRandom.md 'Atrea.Utilities.Random.IRandom')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The method by which the random number generator is to be created.  
  
#### Returns
[IThreadLocalRandomBuilder](./Atrea-Utilities-Random-IThreadLocalRandomBuilder.md 'Atrea.Utilities.Random.IThreadLocalRandomBuilder')  
Returns [IThreadLocalRandomBuilder](./Atrea-Utilities-Random-IThreadLocalRandomBuilder.md 'Atrea.Utilities.Random.IThreadLocalRandomBuilder') which [Build()](./Atrea-Utilities-Random-IThreadLocalRandomBuilder-Build().md 'Atrea.Utilities.Random.IThreadLocalRandomBuilder.Build()') shall be called on.  
