using System;

public class ProjectileMotion
{
    public static void Main(string[] args)
    {
        // Ví dụ sử dụng hàm để tính toán vị trí (x, y) tại thời điểm t = 2s
        Console.WriteLine("Enter your v:");
        double v0 = Convert.ToDouble(Console.ReadLine());// Vận tốc đầu (m/s)
        Console.WriteLine("Enter your a:");
        double a0 = Convert.ToDouble(Console.ReadLine());// Góc ném (độ)
        Console.WriteLine("Enter your time:");
        double t = Convert.ToDouble(Console.ReadLine());// Thời điểm cần tính toán (s)

        // Gọi hàm để tính toán vị trí (x, y)
        double[] position = CalculatePosition(v0, a0, t);

        // Xuất ra kết quả
        Console.WriteLine("Vi tri cua vat the tai thoi diem t = {0}s:", t);
        Console.WriteLine("x = {0}m", position[0]);
        Console.WriteLine("y = {0}m", position[1]);
    }

    public static double[] CalculatePosition(double v0, double a0, double t)
    {
        double g = 9.8;  // Gia tốc trọng trường (m/s^2)

        // Chuyển đổi góc ném từ độ sang radian
        double a0Rad = a0 * Math.PI / 180.0;

        // Tính toán vị trí (x, y)
        double x = v0 * Math.Cos(a0Rad) * t;
        double y = v0 * Math.Sin(a0Rad) * t - 0.5 * g * t * t;

        // Trả về mảng chứa vị trí (x, y)
        return new double[] { x, y };
    }
}
