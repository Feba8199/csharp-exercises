# 01 – Dog Class

## Problem

Define a `Dog` class with `name` (string), `breed` (string) and `weight` (int) fields.

**Constructors**

1. `(name, breed, weight)`
2. `(name, weight)`: breed defaults to `"mixed-breed"`

**Public method:** `Describe()` returns a sentence describing the dog.

| Weight  | Size   |
| ------- | ------ |
| < 5 kg  | tiny   |
| 5–29 kg | medium |
| 30+ kg  | large  |

**Example**

> This dog is named Lucky, it's a german shepherd, and it weighs 40 kilograms, so it's a large dog.

## Concepts used

- **Encapsulation:** fields are private; only `Describe()` is public
- **Constructor chaining:** `: this(name, "mixed-breed", weight)` avoids duplicated assignment logic
- **Switch expression with relational patterns:** `< 5 => "tiny"`
- **String interpolation:** `$"...{name}..."`
- **File-scoped namespace:** `namespace CSharpExercises.DogClass;`

## Run

```bash
dotnet run --project 01-DogClass
```

## Output

```
This dog is named Lucky, it's a german shepherd, and it weighs 40 kilograms, so it's a large dog.
This dog is named Tina, it's a shar pei, and it weighs 25 kilograms, so it's a medium dog.
This dog is named Rex, it's a mixed-breed, and it weighs 3 kilograms, so it's a tiny dog.
```
