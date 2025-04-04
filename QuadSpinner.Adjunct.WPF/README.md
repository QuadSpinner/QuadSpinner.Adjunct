# QuadSpinner.Adjunct.WPF

**QuadSpinner.Adjunct.WPF** is a focused utility library that supercharges your WPF code with clean, high-performance helpers.  
From visibility toggles to animation sugar, it lets you write more expressive and less repetitive UI logic.

---

## 🌟 Highlights

- 🎞️ Lightweight animation helpers (`FadeIn`, `FadeOutAndCollapse`, etc.)
- 👁️ Easy visibility and enabled-state toggles (`Visible()`, `Enable()`, etc.)
- 🎨 Theme-aware brush lookup from resource dictionaries
- 🖼️ Smart window positioning across monitors
- ⚡ Most helpers aggressively inlined for performance

---

## 📦 Installation

```bash
dotnet add package QuadSpinner.Adjunct.WPF
```

```bash
install-package QuadSpinner.Adjunct.WPF
```
---

## 🚀 Usage

### UI Animations

```csharp
myElement.FadeIn();                // Fade in to opacity 1.0
myElement.FadeOut(0.5);           // Fade out to opacity 0.5
myElement.FadeOutAndCollapse();   // Fade and then collapse
```

### Visibility & Enable State

```csharp
myControl.Visible();
myControl.Collapse();
myControl.Hide();

myControl.Enable();
myControl.Disable();
```

### Value Conversions

```csharp
Visibility v = myBool.ToVisibility();
bool isChecked = myCheckbox.IsChecked();
```

### Resource Brushes

```csharp
Brush accent = WPF.GetBrush(BrushName.Blue, BrushSet.Strong);
SolidColorBrush solid = WPF.GetSolidColorBrush(\"Accent-Green\");
```

### Miscellaneous

```csharp
byte[] imageBytes = ...;
BitmapSource bmp = imageBytes.ToBitmapSource(256);
```

---

## 🛠 Feature Flags

To disable animations globally:

```csharp
QuadSpinner.Adjunct.WPF.DisableAnimations = true;
```

---

## 🧭 Namespace

```csharp
using QuadSpinner.Adjunct;

//or

using static QuadSpinner.Adjunct.WPF;
```

---

## 📜 License

MIT. Use it, share it, improve it. Conquer with it.

---

## ⚔️ Authored by

QuadSpinner — creators of Gaea, and architects of terrain tech.