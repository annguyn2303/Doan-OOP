
public abstract class AStaff
{
    // tên, ngày tháng năm sinh, mã nv, nguyên quán, thân nhân, sđt, hệ số lương, giới tính
    // địa chỉ nhà, nơi công tác
    protected string id;
    protected string name;
    protected string birthday;
    protected string hometown;
    protected string marital_status;
    protected string phoneNumber;
    protected int yearOfWork;
    protected double salary_coef;// 0.3 + (10*0.005) * 800k -> trphong (0.3 + 0.2 +(10*0.01)) * 1000k
    protected string relative;
    protected string gender;
    protected string branch;
    protected string address;
    protected string position;

    /*public abstract bool LoginCheck(string id, List<Staff> data);*/
    // tính tổng lương
    public abstract double count_Salary(Staff staffs);
}