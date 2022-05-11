import './Employee.css';

  function Organisation(props) {
    console.log(props);
    return (
     
    <tr className="tablestyle">
    <td className='tableRow'>{props.Name}</td>
    <td className='tableRow'>{props.AddressLine1 }</td>
    <td className='tableRow'>{props.AddressLine2 }</td>
    <td className='tableRow'>{props.AddressLine3 }</td>
    <td className='tableRow'>{props.AddressLine4 }</td>
    <td className='tableRow'>{props.Town         }</td>
    <td className='tableRow'>{props.Postcode     }</td>
    <td className='tableRow'>{props.EmployeeCount}</td>
    </tr>
    );
}

export default Organisation;