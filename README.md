# QuadSpinner.Adjunct

[![NuGet - Core](https://img.shields.io/nuget/v/QuadSpinner.Adjunct.svg?label=QuadSpinner.Adjunct)](https://www.nuget.org/packages/QuadSpinner.Adjunct)  
[![NuGet - WPF](https://img.shields.io/nuget/v/QuadSpinner.Adjunct.WPF.svg?label=QuadSpinner.Adjunct.WPF)](https://www.nuget.org/packages/QuadSpinner.Adjunct.WPF)  
[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

**QuadSpinner.Adjunct** is a high-performance extension and helper library for .NET and WPF developers.  
It delivers ultra-light syntax sugar, aggressive inlining, and thoughtfully crafted utilities to streamline your code across both logic and UI layers.

---

## 📦 Packages

| Package                     | NuGet                             | Version                         |
|-----------------------------|-----------------------------------|---------------------------------|
| `QuadSpinner.Adjunct`       | `install-package QuadSpinner.Adjunct` | ![NuGet](https://img.shields.io/nuget/v/QuadSpinner.Adjunct.svg) |
| `QuadSpinner.Adjunct.WPF`   | `install-package QuadSpinner.Adjunct.WPF` | ![NuGet](https://img.shields.io/nuget/v/QuadSpinner.Adjunct.WPF.svg) |

---

## 🔧 QuadSpinner.Adjunct (Core)

Essential, fast, and elegant. The core package includes:

### ✨ Math & Numerics

```csharp
5.Square();             // 25
9.SquareRoot();         // 3
value.Clamp01();        // Clamp float between 0 and 1
```

### 🔤 Strings

```csharp
"abc123".OnlyDigits();            // "123"
"abc123".WithoutDigits();         // "abc"
"long text".Truncate(4);          // "long"
```

### 📁 Paths & Files

```csharp
path.IsFile();                    // True if file exists
path.WithExtension(".json");     // Changes extension
path.AssignIfEmpty(defaultPath); // Fallback logic
```

### ⚙️ Enums

```csharp
EnumHelper.ParseEnum<Mode>("Fast");
EnumHelper.GetEnumStrings<BrushName>(); // ["Accent", "Primary", ...]
```

### 🧪 Booleans

```csharp
flag.Toggle();                    // !flag
flag.ToByte();                    // 1 or 0
```

### 🧵 Arrays

```csharp
byte[] copy = data.Copy();        // Fast clone
```

---

## 🎨 QuadSpinner.Adjunct.WPF

UI helpers designed for WPF developers who value clarity and performance. No bloat, no dependencies.

### ✨ Animations

```csharp
element.FadeIn();
element.FadeOutAndCollapse();
```

### 👁️ Visibility & State

```csharp
element.Visible();
element.Collapse();
element.Enable();
```

### 🖌️ Brush Access

```csharp
var brush = WPF.GetBrush(BrushName.Blue, BrushSet.Muted);
```

---

## 🛠 Feature Toggle

Disable animations globally at runtime:

```csharp
QuadSpinner.Adjunct.WPF.Features.DisableAnimations = true;
```

---

## 🧭 Namespace

```csharp
using QuadSpinner.Adjunct;
using QuadSpinner.Adjunct.WPF;
```

---

## 📜 License

MIT — Open source, commercial-ready.

---

## 🧠 Created by

**QuadSpinner** — creators of [Gaea](https://quadspinner.com), the procedural terrain engine trusted by top studios.
