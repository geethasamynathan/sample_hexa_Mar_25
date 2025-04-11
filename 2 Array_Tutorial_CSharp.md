# Array in C# – Complete Tutorial

---

## 📦 What is an Array in C#?

An **array** in C# is a **collection of elements** that are stored in **contiguous memory locations**. All elements in the array must be of the **same data type**.

---

## ✅ Why Use Arrays?

- Store **multiple values** in a single variable
- Improve **data organization**
- Access elements by **index**
- Easy to **iterate** using loops

---

## 🔹 Array Syntax

```csharp
datatype[] arrayName = new datatype[size];
```

Or initialize directly:

```csharp
int[] numbers = { 10, 20, 30, 40 };
```

---

## 🔸 Types of Arrays in C#

| Type                | Description                                |
|---------------------|--------------------------------------------|
| **Single-dimensional** | Most common; a simple list of values       |
| **Multi-dimensional**  | Table-like structure (matrix)             |
| **Jagged array**       | Array of arrays (rows can have different sizes) |

---

## 🔹 1. Single-Dimensional Array

```csharp
string[] fruits = { "Apple", "Banana", "Mango" };

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

### Real-world Use Case:
- Store a list of product names
- Record temperatures for a week

---

## 🔹 2. Multi-Dimensional Array (Rectangular)

```csharp
int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6}
};

Console.WriteLine(matrix[1, 2]);  // Output: 6
```

### Real-world Use Case:
- Represent a **chessboard**
- Store student scores in a grid

---

## 🔹 3. Jagged Array (Array of Arrays)

```csharp
int[][] jagged = new int[3][];
jagged[0] = new int[] { 1, 2 };
jagged[1] = new int[] { 3, 4, 5 };
jagged[2] = new int[] { 6 };

foreach (int[] row in jagged)
{
    foreach (int item in row)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
```

### Real-world Use Case:
- Different number of subjects per student
- Playlist with different number of songs

---

## 🧪 Arrays with Different Data Types

### 🔸 Integer Array
```csharp
int[] ids = { 101, 102, 103 };
```

### 🔸 String Array
```csharp
string[] cities = { "London", "Paris", "Delhi" };
```

### 🔸 Boolean Array
```csharp
bool[] status = { true, false, true };
```

### 🔸 Object Array (Holds any type)
```csharp
object[] mixed = { 1, "Text", true, 9.8 };
```

---

## 🛠 Useful Properties and Methods

| Feature              | Usage                            |
|----------------------|----------------------------------|
| `Length`             | Get total number of elements     |
| `Sort()`             | Sort array elements              |
| `Reverse()`          | Reverse array elements           |
| `IndexOf()`          | Find index of an element         |

---

## 💡 Tips

- Arrays are **fixed size**. Use `List<T>` for dynamic collections.
- Use **foreach loop** for read-only iteration.
- Use `Array.Copy()` for copying elements.
