# Structure in C#.NET

A **structure (struct)** in C# is a **value type** that is used to store a group of related variables (fields) under one name. It is defined using the `struct` keyword.

---

## 🔹 Syntax
```csharp
public struct Person
{
    public string Name;
    public int Age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
```

---

## 🔹 Example Usage
```csharp
Person p;
p.Name = "Alice";
p.Age = 30;
p.DisplayInfo();  // Output: Name: Alice, Age: 30
```

---

## ✅ Similarities Between Class and Structure

| Feature               | Struct                              | Class                              |
|-----------------------|--------------------------------------|-------------------------------------|
| Can have fields       | ✅                                   | ✅                                  |
| Can have methods      | ✅                                   | ✅                                  |
| Can have properties   | ✅                                   | ✅                                  |
| Can use access modifiers | ✅                                | ✅                                  |
| Can implement interfaces | ✅                                | ✅                                  |
| Can have constructors | ✅ (parameterized only)              | ✅ (default & parameterized)        |

---

## 🔄 Differences Between Class and Structure

| Feature                       | Struct (Value Type)                    | Class (Reference Type)                |
|-------------------------------|----------------------------------------|----------------------------------------|
| Stored in                     | Stack                                 | Heap                                   |
| Memory Allocation             | Lightweight                           | Heavier (heap + garbage collection)    |
| Inheritance                   | ❌ Cannot inherit from another struct/class | ✅ Can inherit from another class       |
| Default Constructor           | ❌ Cannot define a default constructor | ✅ Can define                            |
| Nullability                   | ❌ Cannot be null (unless nullable)    | ✅ Can be null                           |
| Used For                      | Small, simple objects                  | Complex, large-scale objects            |

---

## 🧠 When to Use Class vs Structure

### ✅ Use **Structure** when:
- You need a **lightweight object**.
- The object will **not be modified after creation**.
- The object is **small in size and has value semantics**.
- You want to **avoid heap allocation** (e.g., performance-critical scenarios).

### ✅ Use **Class** when:
- You need to implement **inheritance or polymorphism**.
- The object is **large or complex**.
- You need **reference semantics**.
- You want to take advantage of **garbage collection**.
