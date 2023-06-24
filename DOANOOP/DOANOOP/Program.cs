// id, ten, sdt, chức vụ, thân nhân, tình trạng hôn nhân, địa chỉ nhà, nơi công tác
// kế thừa tạo ra class trường phòng, nhân viên
// chấm công
// tính lương-trừ lương
// operator nhanvien++ -> add nhân viên
// operator nhanvien-- -> remove nhân viên
// delegate để sắp xếp tên

// QUẢN LÝ NHÂN VIÊN CÔNG TY

public class Program
{
    public static void Main()
    {
        List<Staff> staffs = new List<Staff>();
        Staff staff1 = new Staff();
        staffs.Add(new Staff("S01", "Nguyen An", "Ha Noi", "23/03/2002","Nam", "Doc than", 5, 2.5, "HCM", "Nha an", "Truong phong"));
        staffs.Add(new Staff("QL02", "Nguyen Hung", "12/02/2002", "Nam","Da Nang", "Doc than", 4, 2.0, "ncmn", "nha hung", "Quan ly"));
        staffs.Add(new Staff("QL01", "Kha Banh", "Ha Noi", "23/03/2002", "Nam", "Doc than", 5, 1.5, "HCM", "Nha an", "Nhan vien"));
        staffs.Add(new Staff("QL03", "Khanh Ly", "12/02/2002", "Nam", "Da Nang", "Doc than", 4, 1.5, "ncmn", "nha hung", "Nhan vien"));
        staffs.Add(new Staff("S03", "Lam Kien", "Ha Noi", "23/03/2002", "Nam", "Doc than", 5, 1.5, "HCM", "Nha an", "Nhan vien"));
        staffs.Add(new Staff("QL04", "Duong Thai", "12/02/2002", "Nam", "Da Nang", "Doc than", 4, 2.0, "ncmn", "nha hung", "Quan ly"));
        /*Console.Write("So nhan vien can them: ");
        int value = int.Parse(Console.ReadLine());
        for (int i = 0; i < value; i++)
        {
            staff1.AddStaff(staffs);
        }*/

        /*staff1.print_Salary(staffs);
        Console.WriteLine("Luong cua ca cong ty: " + staff1.Sum_Salary(staffs));*/
        staff1.PrintIn4(staffs);
        //===================
        Staff s1 = new Staff();
        Console.Write("NHAP ID: ");
        string id = Console.ReadLine();
        foreach (Staff staff in staffs)
        {
            if (staff.Id.ToLower().Equals(id.ToLower()))
                s1 = staff;
        }
        s1++;
        Console.WriteLine(s1);

       

        

    }
   
}
