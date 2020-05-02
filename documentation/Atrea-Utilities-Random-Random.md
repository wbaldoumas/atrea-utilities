#### [Atrea.Utilities](./index.md 'index')
### [Atrea.Utilities.Random](./Atrea-Utilities-Random.md 'Atrea.Utilities.Random')
## Random Class
An implementation of [IRandom](./Atrea-Utilities-Random-IRandom.md 'Atrea.Utilities.Random.IRandom') which delegates its calls to [System.Random](https://docs.microsoft.com/en-us/dotnet/api/System.Random 'System.Random')  
This should be used when you need performance over cryptographically strong randomness. For a more  
cryptographically strong random number generation, see [CryptoRandom](./Atrea-Utilities-Random-CryptoRandom.md 'Atrea.Utilities.Random.CryptoRandom').  
```csharp
public class Random : Random,
IRandom
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &gt; [System.Random](https://docs.microsoft.com/en-us/dotnet/api/System.Random 'System.Random') &gt; [Random](./Atrea-Utilities-Random-Random.md 'Atrea.Utilities.Random.Random')  

Implements [IRandom](./Atrea-Utilities-Random-IRandom.md 'Atrea.Utilities.Random.IRandom')  
