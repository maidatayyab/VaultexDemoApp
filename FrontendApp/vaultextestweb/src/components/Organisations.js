import './Employee.css';
import Organisation from './Organisation';

  function Organisations(props) {
    console.log(props.Organisationss);
    return (
        <table className="tablestyle">
        <th className="tableHeader">Name</th>
        <th className="tableHeader">AddressLine 1</th>
        <th className="tableHeader">AddressLine 2</th>
        <th className="tableHeader">AddressLine 3</th>
        <th className="tableHeader">AddressLine 4</th>
        <th className="tableHeader">Town</th>
        <th className="tableHeader">Postcode</th>
        <th className="tableHeader">Employee Count</th>
        {
        props.Organisations.map((org) => (
        <Organisation
        Name         = {org.organisationName}
        AddressLine1 = {org.addressLine1 }
        AddressLine2 = {org.addressLine2 }
        AddressLine3 = {org.addressLine3 }
        AddressLine4 = {org.addressLine4 }
		    Town         = {org.town         }
        Postcode     = {org.postcode     }
        EmployeeCount     = {org.employeeCount     }
        />
        ))}

        </table>
    );
}

export default Organisations;