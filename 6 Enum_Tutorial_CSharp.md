# Enum in C# – Beginner to Advanced Tutorial

---

## 🧾 What is an Enum in C#?

An **Enum** (short for *Enumeration*) is a **special "value type"** that lets you define a set of **named constants**.

It improves **code readability**, **type safety**, and **maintainability** when working with related constant values.

---

## ✅ Why Use Enums?

- Avoids using **magic numbers or strings**
- Increases **readability** of code
- Enables **strong typing**
- Makes **debugging easier**
- Works well with **switch statements**, **comparisons**, and **flags**

---

## 🔹 Basic Syntax

```csharp
enum EnumName
{
    Constant1,
    Constant2,
    Constant3
}
```

---

## 🟢 Beginner Level Example – Days of the Week

```csharp
enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        Days today = Days.Wednesday;
        Console.WriteLine("Today is " + today);  // Output: Today is Wednesday
    }
}
```

- By default, enum members start from 0 and increment by 1.
- You can assign specific values too.

---

## 🟡 Intermediate Example – Order Status

```csharp
enum OrderStatus
{
    Pending = 1,
    Processing = 2,
    Shipped = 3,
    Delivered = 4,
    Cancelled = 5
}

class Order
{
    public OrderStatus Status { get; set; }

    public void PrintStatus()
    {
        Console.WriteLine($"Current Status: {Status}");
    }
}
```

### Usage:
```csharp
Order myOrder = new Order();
myOrder.Status = OrderStatus.Shipped;
myOrder.PrintStatus(); // Output: Current Status: Shipped
```

---

## 🔴 Advanced Example – Using Enums with Flags

The `[Flags]` attribute allows an enum to hold **multiple values** using **bitwise operations**.

```csharp
[Flags]
enum FileAccess
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}

class Program
{
    static void Main()
    {
        FileAccess access = FileAccess.Read | FileAccess.Write;
        Console.WriteLine(access);  // Output: Read, Write

        // Check if Write is included
        bool canWrite = (access & FileAccess.Write) == FileAccess.Write;
        Console.WriteLine("Can Write: " + canWrite);  // Output: Can Write: True
    }
}
```

---

## 🧠 Enum Tips

- Use `Enum.GetValues()` and `Enum.GetNames()` to iterate.
- Cast integers to enums: `(Days)3` returns `Wednesday`.
- Enums are implicitly of type `int` but can be changed to `byte`, `short`, etc.
