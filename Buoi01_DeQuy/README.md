	# Buổi 01 – Đệ quy

Họ tên: Phạm Văn Tú Anh · MSV: 12425093

## Bài đã làm
Chương 1: Tổng quan về cấu trúc dữ liệu và giải thuật: Bài 1, 2, 3, 4, 5

Chương 2: Phân tích giải thuật: Bài 1, 2, 3, 4, 5, 6

Chương 3 Đệ quy: Bài 1, 2, 3, 4, 5, 6, 7, 8

Chương trình là một menu console: chọn chương, rồi chọn bài cần chạy.

## Cách chạy
```
dotnet run --project Buoi01_DeQuy
```

## Kết quả chạy

### Chương 1
```
 Bài 1: Số lớn nhất, nhỏ nhất trong mảng 1000 số 
Số lớn nhất: 9996 | Số nhỏ nhất: 16
```
```
 Bài 2: FizzBuzz 
1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz
```
```
 Bài 3: Đảo ngược chuỗi 
Chuỗi gốc: "Cấu trúc dữ liệu và giải thuật" => Đảo ngược: "tậuht iảig àv uệil ữd cúrt uấC"
```
```
 Bài 4: Sắp xếp mảng 1000 số 
15 phần tử đầu trước khi sắp xếp: 2221 6893 2433 5248 7632 301 7572 3514 8969 5882 75 1369 7370 225 6558
15 phần tử đầu sau khi sắp xếp tăng: 21 25 33 55 62 64 75 91 106 117 122 123 134 135 142
```
```
 Bài 5: Fibonacci thứ n 
F(10) = 55
```

### Chương 2
```
 Bài 3: Kiểm tra số nguyên tố 
- Giải thuật 1 (Duyệt đến n-1): Kết quả = True | Thời gian = 1.3197 ms
- Giải thuật 2 (Duyệt đến căn n): Kết quả = True | Thời gian = 0.0016 ms
```
```
 Bài 4: Số hoàn hảo 
- Giải thuật 1 (Cơ bản - O(N^2)): 6 28 496 8128 | Thời gian = 66.0128 ms
- Giải thuật 2 (Cải tiến căn bậc 2 - O(N*sqrt(N))): 6 28 496 8128 | Thời gian = 1.8080 ms
```
```
 Bài 5: Fibonacci thứ n (so sánh 4 cách) 
- Giải thuật 1 (Đệ quy trực tiếp O(2^n)): F(35) = 9227465 | Thời gian = 69.5100 ms
- Giải thuật 2 (Vòng lặp O(n)): F(35) = 9227465 | Thời gian = 0.2147 ms
```
```
 Bài 6: Sắp xếp dãy số thực 
- Giải thuật 1 (Bubble Sort - O(n^2)): Thời gian = 39.1740 ms
- Giải thuật 2 (Selection Sort - O(n^2)): Thời gian = 15.4771 ms
```

### Chương 3 (Đệ quy)
```
 Bài 1: S(n) = 1 + 2 + ... + n 
Với n = 5 => S(5) = 15
```
```
 Bài 2: S(n) = 1 + 2^2 + ... + n^2 
Với n = 4 => S(4) = 30
```
```
 Bài 3: S(n) = 1 + 1/2 + ... + 1/n 
Với n = 5 => S(5) = 2.2833
```
```
 Bài 4: S(x, n) = x^n 
Với x = 2, n = 3 => S(2, 3) = 8
Với x = 2, n = -2 => S(2, -2) = 0.25
```
```
 Bài 5: Ước số lẻ lớn nhất 
Ước lẻ lớn nhất của 100 là: 25
```
```
 Bài 6: Ước chung lớn nhất 
UCLN(48, 18) = 6
```
```
 Bài 7: Đếm số chữ số 
Số chữ số của 123456 là: 6
```
```
 Bài 8: Tổng căn lồng nhau 
Với n = 4 => S(4) = 1.7488
```
