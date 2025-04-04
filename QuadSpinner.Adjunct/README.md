# QuadSpinner.Adjunct

**QuadSpinner.Adjunct** is a high-performance utility library packed with finely-tuned extension methods and helpers to augment your .NET projects with elegance, precision, and speed.  
Crafted for pros. Ready for production.

---

## 🔥 Why Adjunct?

- ✅ Aggressively inlined methods for maximum performance  
- ✅ Clean, readable syntax: `value.Half()` > `value / 2f`  
- ✅ Battle-tested sugar—no bloat, no nonsense  
- ✅ Covers numbers, strings, files, enums, arrays, and more  
- ✅ Designed for utility, built for speed

---

## 📦 Install via NuGet

```bash
dotnet add package QuadSpinner.Adjunct
```

```bash
install-package QuadSpinner.Adjunct
```

Or search `QuadSpinner.Adjunct` in the NuGet Package Manager UI.

---

## 🧠 Highlights

### Math & Numerics
```csharp
5.Square();           // 25
9.SquareRoot();       // 3
10f.Half();           // 5f
value.Clamp01();      // Clamps between 0 and 1
42.IsEven();          // true
```

### Strings
```csharp
"hello123".OnlyDigits();           // "123"
"hello123".WithoutDigits();        // "hello"
someString.Truncate(10);           // Trim string safely
lines.ToLines();                   // string[] → joined by newlines
```

### Paths & Files
```csharp
path.IsFile();                     // true if file exists
path.WithExtension(\".txt\");       // change extension
path.AssignIfEmpty(defaultPath);  // fallback if path is null/invalid
```

### Booleans
```csharp
flag.Toggle();                     // !flag
flag.ToByte();                     // 1 or 0
```

### Enums
```csharp
EnumHelper.ParseEnum<Mode>(\"Fast\");
EnumHelper.ToInt(Mode.Fast);
EnumHelper.GetEnumStrings<Mode>();     // [\"Fast\", \"Slow\", ...]
```

### Arrays
```csharp
byte[] copy = data.Copy();         // Fast array clone
```

---

## 📁 Namespace

All helpers live in:  
```csharp
using QuadSpinner.Adjunct;
```

---

## 📜 License

MIT. Use it, share it, improve it. Conquer with it.

---

## ⚔️ Authored by

QuadSpinner — creators of Gaea, and architects of terrain tech.