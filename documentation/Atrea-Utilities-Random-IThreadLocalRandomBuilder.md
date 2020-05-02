#### [Atrea.Utilities](./index.md 'index')
### [Atrea.Utilities.Random](./Atrea-Utilities-Random.md 'Atrea.Utilities.Random')
## IThreadLocalRandomBuilder Interface
A builder for creating thread-safe random number generators which implement the [IRandom](./Atrea-Utilities-Random-IRandom.md 'Atrea.Utilities.Random.IRandom') interface.  
For more info on the subject of thread-safe randomness, see the following:  

https://codeblog.jonskeet.uk/2009/11/04/revisiting-randomness/  
https://devblogs.microsoft.com/pfxteam/getting-random-numbers-in-a-thread-safe-way/"  
```csharp
public interface IThreadLocalRandomBuilder
```
### Methods
- [Build()](./Atrea-Utilities-Random-IThreadLocalRandomBuilder-Build().md 'Atrea.Utilities.Random.IThreadLocalRandomBuilder.Build()')
- [WithGeneratorValueFactory(System.Func&lt;Atrea.Utilities.Random.IRandom&gt;)](./Atrea-Utilities-Random-IThreadLocalRandomBuilder-WithGeneratorValueFactory(System-Func-Atrea-Utilities-Random-IRandom-).md 'Atrea.Utilities.Random.IThreadLocalRandomBuilder.WithGeneratorValueFactory(System.Func&lt;Atrea.Utilities.Random.IRandom&gt;)')
