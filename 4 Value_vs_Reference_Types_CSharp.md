# Value Type vs Reference Type in C#.NET

---

## 🔹 What is a Value Type in C#?

A **Value Type** directly contains its **value**. It is stored in the **stack**, and each variable gets its own **copy** of the data.

### ✅ Examples:
- Built-in types: `int`, `float`, `bool`, `char`, `double`
- Custom types: `struct`, `enum`

---

## 🔹 What is a Reference Type in C#?

A **Reference Type** stores a **reference (address)** to the actual data, which is stored in the **heap**. Multiple variables can refer to the **same object**.

### ✅ Examples:
- `class`, `interface`, `delegate`, `string`, `object`

---

## 📘 Real-World Scenario Example

### 🔸 Value Type – Temperature Sensor Reading
```csharp
struct Temperature
{
    public float Celsius;
}
```
- When storing a temperature reading from a sensor, a simple `struct` is used.
- Each reading is independent and small in size.

### 🔸 Reference Type – Employee Record
```csharp
class Employee
{
    public string Name;
    public string Department;
}
```
- A class is used to model complex entities like employees, allowing shared references, inheritance, and polymorphism.

---

## 🔄 Differences Between Value Type and Reference Type

| Feature                    | Value Type                          | Reference Type                         |
|----------------------------|--------------------------------------|----------------------------------------|
| Stored in                  | Stack                               | Heap                                   |
| Contains                   | Actual value                        | Address (reference) to the data        |
| Memory allocation          | Faster                              | Slower (due to heap allocation)        |
| Default value              | Zero-equivalent                     | `null`                                 |
| Can be null?               | ❌ No (unless nullable)             | ✅ Yes                                  |
| Behavior on assignment     | Copy of value                       | Copy of reference                      |
| Inheritance                | ❌ Not supported                    | ✅ Supported                            |

---

## ✅ Similarities

| Feature                   | Value Type     | Reference Type |
|---------------------------|----------------|----------------|
| Can be passed to methods  | ✅             | ✅             |
| Can be part of collections| ✅             | ✅             |
| Can have fields/properties| ✅ (struct)    | ✅ (class)     |
| Can implement interfaces  | ✅             | ✅             |

---

## 📌 When to Use Which?

### ✅ Use **Value Type** when:
- Data is small and short-lived.
- You don’t need to modify the original data.
- You want to avoid heap allocations (performance).

### ✅ Use **Reference Type** when:
- Data is large or complex.
- You need polymorphism or inheritance.
- You want to share data between multiple parts of the application.
