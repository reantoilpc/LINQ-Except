### LINQ Except 使用需注意地方

- Except 是以 Euquals 比對結果當依據，當使用在數值型資料(string、int)，可以幫助我們找出兩個 IEnumerable<T> 集合的差異項目。
- 但是使用在自訂類別上就會發現，執行結果就不如預期，沒有排除相同項目。
- 因為自訂類別是屬於 Reference Type 變數需要指向同一個記憶體位址，才算相同

### 自訂類別如何正常使用 LINQ Except 

- [微軟在說明文件就有提供解套方式](https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.except?view=netframework-4.8#code-try-1)

### 方法 1 ： 實作 IEquatable 泛型介面，並覆寫 Equals 和 GetHashCode 方法。

### 方法 2 ： 實作 IEqualityComparer 泛型介面的比較器