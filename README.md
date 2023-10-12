# String Building

## Description

Let's assume you need to generate a long string (length 1000) containing the same character. I can think of three ways:

- Use a `while` loop that appends the character 1000 times to a string variable.
- Use a `while` loop that appends the character 1000 times to a `StringBUilder`.
- Use the constructor of the `System.String` class.

**Question**

- Which is more performant and what is the difference?

## Conclusion

Pretty much what is expected:

- String concatenation is much slower than using `StringBuilder`.
- String constructor is much quicker than `StringBuilder`.

### Notes

- String constructor, even if it is the most performant, can be used only for a limited range of situations:
  - when the string is created repeating the same character.
- On the other hand `StringBuilder` is the best universal approach for concatenating any strings, of any lengths.

## Measurements

| Method        | StringLength |          Mean |      Error |       StdDev |        Median |
| ------------- | ------------ | ------------: | ---------: | -----------: | ------------: |
| Concatenation | 100          |   2,856.07 ns |  65.799 ns |   274.257 ns |   2,803.80 ns |
| StringBuilder | 100          |     348.44 ns |   6.434 ns |    26.887 ns |     347.03 ns |
| 'String ctor' | 100          |      41.93 ns |   1.001 ns |     4.118 ns |      40.33 ns |
| Concatenation | 1000         | 104,271.34 ns | 929.487 ns | 3,811.934 ns | 103,092.47 ns |
| StringBuilder | 1000         |   2,955.03 ns |  50.705 ns |   211.907 ns |   2,937.97 ns |
| 'String ctor' | 1000         |     312.96 ns |   6.465 ns |    26.073 ns |     303.51 ns |

See the full benchmark results and logs in the `/doc/benchmark-results` directory.

## Donations

> If you like my work and want to support me, you can buy me a coffee:
>
> [![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/Y8Y62EZ8H)

