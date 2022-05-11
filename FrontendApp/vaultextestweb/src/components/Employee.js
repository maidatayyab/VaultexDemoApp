import './Employee.css';

  function Employee(props) {
    console.log(props);
    return (
     
      <tr className="tablestyle">
        <td className='tableRow'>{props.FirstName}</td>
        <td className='tableRow'>{props.LastName}</td>
        <td className='tableRow'>{props.OrganisationName}</td>
      </tr>
    );
}

export default Employee;