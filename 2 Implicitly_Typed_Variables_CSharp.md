# Implicitly Typed Variables in C#.NET

In **C#.NET**, an **implicitly typed variable** is a variable declared using the `var` keyword, where the compiler **infers the type of the variable at compile time** based on the value assigned to it.

---

## 🔹 Syntax
```csharp
var variableName = value;
```

---

## 🔹 Example
```csharp
var number = 10;          // Compiler infers it as int
var name = "John";        // Compiler infers it as string
var price = 99.99;        // Compiler infers it as double
```

---

## ✅ Key Points
- The **type is determined at compile time**, not runtime.
- Once inferred, the type **cannot change**.
- You **must initialize** the variable at the time of declaration.
- Improves readability when the type is obvious or complex.

---

## ❌ Invalid Example
```csharp
var something;            // ❌ Error: Must be initialized
```

---

## 📌 When to Use
- When the type is **obvious** from the right-hand side.
- When working with **anonymous types**.
- To make code **cleaner and easier** to read.

---

## 🔍 Behind the Scenes
Even though `var` is used, the compiler still generates a **strongly typed variable**. There is **no loss of type safety**.
