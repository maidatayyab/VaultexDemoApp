import './Employee.css';
import Employee from './Employee';

  function Employees(props) {
   // console.log(props.Employees);
    return (
        <table className="tablestyle">
        <th className="tableHeader">First Name</th>
        <th className="tableHeader">Last Name</th>
        <th className="tableHeader">Organizaion</th>
        {
        props.Employees.map((employee) => (
        <Employee
        FirstName={employee.firstName}
        LastName={employee.lastName}
        OrganisationName={employee.organisationName}
        />
        ))}

        </table>
    );
}

export default Employees;