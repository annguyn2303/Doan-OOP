public class Staff : AStaff
{
    public string Id
    {
        get { return id; }
    }
    public double Salary_coef
    {
        get { return salary_coef; }
        set { salary_coef = value; }
    }
    public Staff()
    {
            
    }
    // Constructor
    public Staff(string id, string name, string birthday, string gender,string hometown, string marital_status, int yearOfWork, double salary_coef, string branch, string address, string position)
    {
        this.id = id;
        this.name = name;
        this.birthday = birthday;
        this.gender = gender;
        this.hometown = hometown;
        this.marital_status = marital_status;
        this.yearOfWork = yearOfWork;
        this.salary_coef = salary_coef;
        this.branch = branch;
        this.address = address;
        this.position = position;
    }
    // To string
    public override string ToString()
    {
        return id + " " + name + " " + position + " " + salary_coef;
    }
    // Hàm thêm nhân viên
    public void  AddStaff(List<Staff> data)
    {
        Console.WriteLine("Nhap thong tin: ");
        Console.WriteLine("Nhap ID nhan vien: ");
        string StaffId = Console.ReadLine();
        Console.WriteLine("Nhap ten nhan vien: ");
        string StaffName = Console.ReadLine();
        Console.WriteLine("Nhap ngay sinh (dd/mm/yyyy): ");
        string StaffBirthday = Console.ReadLine();
        Console.WriteLine("Nhap gioi tinh nhan vien: ");
        string StaffGender = Console.ReadLine();
        Console.WriteLine("Nhap nguyen quan: ");
        string StaffHometown = Console.ReadLine();
        Console.WriteLine("Nhap tinh trang hon nhan: ");
        string StaffMarital_status = Console.ReadLine();
        Console.WriteLine("Nhap so nam cong tac: ");
        int StaffYearOfWork = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chi nhanh cong tac: ");
        string StaffBranch = Console.ReadLine();
        Console.WriteLine("Nhap dia chi thuong tru: ");
        string StaffAddress = Console.ReadLine();
        Console.WriteLine("Nhap vi tri cong tac: ");
        string StaffPosition = Console.ReadLine();
        double StaffSalary_coef;
        if (StaffPosition == "Truong phong")
            StaffSalary_coef = 2.5;
        else if (StaffPosition == "Quan ly")
            StaffSalary_coef = 2.0;
        else StaffSalary_coef = 1.5;

        data.Add(new Staff(StaffId, StaffName, StaffBirthday, StaffGender, StaffHometown, StaffMarital_status, StaffYearOfWork, StaffSalary_coef, StaffBranch, StaffAddress, StaffPosition));        
    }
    // Hàm Remove nhân viên theo Id
    public void RemoveStaff(List<Staff> data)
    {
        Console.WriteLine("Nhap Id nhan vien can xoa bo: ");
        string idstaff = Console.ReadLine();
        foreach (Staff staff in data)
        {
            if (staff.id.ToLower().Equals(idstaff.ToLower()))
            {
                data.Remove(staff);
            }
        }
    }
    // Hàm tìm kiếm nhân viên theo Id
    public void SearchStaff_Id(List<Staff> data)
    {
        Console.WriteLine("Nhap ID cua nhan vien de tim thong tin: ");
        string idstaff = Console.ReadLine();
        foreach(Staff staff in data)
        {
            if (staff.id.ToLower().Contains(idstaff.ToLower()))
            {
                Console.WriteLine(staff.ToString());
            }
        }
    }
    // Hàm tìm kiếm nhân viên theo tên
    public void SearchStaff_Name(List<Staff> data)
    {
        Console.WriteLine("Nhap tên cua nhan vien de tim thong tin: ");
        string namestaff = Console.ReadLine();
        foreach (Staff staff in data)
        {
            if (staff.name.ToLower().Contains(namestaff.ToLower()))
            {
                Console.WriteLine(staff.ToString());
            }
        }
    }
    // Hàm tìm kiếm nhân viên theo chi nhánh
    public void SearchStaff_Branch(List<Staff> data)
    {
        Console.WriteLine("Nhap tên cua chi nhánh de tim thong tin nhân viên: ");
        string branch = Console.ReadLine();
        foreach (Staff staff in data)
        {
            if (staff.branch.ToLower().Equals(branch.ToLower()))
            {
                Console.WriteLine(staff.ToString());
            }
        }
    }
    // Hàm tìm kiếm nhân viên theo chức vụ
    public void SearchStaff_Position(List<Staff> data)
    {
        Console.WriteLine("Nhap chuc vu cua nhan vien de tim thong tin: ");
        string positionstaff = Console.ReadLine();
        foreach (Staff staff in data)
        {
            if (staff.position.ToLower().Equals(positionstaff.ToLower()))
            {
                Console.WriteLine(staff.ToString());
            }
        }
    }
    // Hàm tìm kiếm nhân viên theo giới tính
    public void SearchStaff_Gender(List<Staff> data)
    {
        Console.WriteLine("Nhap gioi tinh cua nhan vien de tim thong tin: ");
        string genderstaff = Console.ReadLine();
        foreach (Staff staff in data)
        {
            if (staff.gender.ToLower().Equals(genderstaff.ToLower()))
            {
                Console.WriteLine(staff.ToString());
            }
        }
    }
    // Hàm in ra thông tin tất cả nhân viên
    public void PrintIn4(List<Staff> data)
    {
        CompareStaff cmp = new CompareStaff(Staff.CompareName);
        Sort(data, cmp);
        foreach(Staff staff in data)
        {
            Console.WriteLine(staff.ToString());
        }
    }

    // Hàm check in đi làm
    public void Logincheck(List<Staff> data)
    {
        Console.WriteLine("Nhap ID de check in: ");
        string id = Console.ReadLine();
        foreach (Staff t in data)
        {
            if (t.id.Equals(id))
            {
                Console.WriteLine($"{t.name} ({t.id}) da check in di lam vao luc {DateTime.Now}");
            }
        }
    }
    // Hàm tính lương nhân viên 
    // salary_coef : nhân viên: 1.2 -  quản lý: 1.5 - trưởng phòng: 2.0
    // In ra lương các nhân viên
    public void print_Salary(List<Staff> data)
    {
        foreach (Staff s in data)
        {
            Console.WriteLine($"{s.name} co luong la ${Math.Round(s.count_Salary(s))}");
        }
    }
    public override double count_Salary(Staff staffs)
    {
        double salary = (staffs.salary_coef + staffs.yearOfWork * 0.005) * 5000;
        return salary;
    }

    // Tính tổng lương của cả công ty
    public double Sum_Salary(List<Staff> data)
    {
        double sum = 0;
        foreach (Staff staff in data)
        {
            sum += staff.count_Salary(staff);
        }
        return sum;
    }
    // Delegate in theo a,b,c 

    public delegate bool CompareStaff(Staff st1, Staff st2);

    public static void Sort(List<Staff> stf, CompareStaff cmp)
    {
        for (int i = 0; i < stf.Count - 1; i++)
        {
            for (int j = i + 1; j < stf.Count; j++)
            {
                if (cmp(stf[i], stf[j]))
                {
                    Staff temp = stf[i];
                    stf[i] = stf[j];
                    stf[j] = temp;
                }
            }
        }

    }

    public static bool CompareName(Staff p1, Staff p2)
    {
        string[] arrayStr1 = (p1.name).Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries); //=>> chỗ này nó sẽ split ra 1 mảng 3 phần t
        string lastName1 = arrayStr1[arrayStr1.Length - 1];
        string[] arrayStr2 = (p2.name).Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries); //=>> chỗ này nó sẽ split ra 1 mảng 3 phần t
        string lastName2 = arrayStr2[arrayStr2.Length - 1];
        if (lastName1.ToLower().CompareTo(lastName2.ToLower()) > 0)
            return true;
        return false;
    }
    // operate
    public static Staff operator ++(Staff s1)
    {  
        s1.Salary_coef = s1.salary_coef + 0.5;
        return s1;
    }
}



