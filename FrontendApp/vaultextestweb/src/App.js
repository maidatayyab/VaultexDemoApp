import React, { useState, useEffect } from 'react'
import Employees from './components/Employees';
import Organisations from './components/Organisations';
import './App.css';

function App() {

  const buttonText = "Show Organisation Data"
  const [EmployeeList, fetchEmployees] = useState([])
  const [OrganisationList, fetchOrganisations] = useState([])
  const [showEmployeeData, updateShowEmployeeData] = useState(true)
  const getEmployeeData = () => {

    fetch('https://localhost:7045/Employee', {
      method: 'GET',
      headers: {
        'Content-Type': 'application/json',
        'Access-Control-Allow-Origin': '*'
      }})
        .then(response => {
          return response.json();
        })
        .then(data => {
          fetchEmployees(data)
        });
  } 

  const getOrganisationData = () => {

    fetch('https://localhost:7045/Organisation', {
      method: 'GET',
      headers: {
        'Content-Type': 'application/json',
        'Access-Control-Allow-Origin': '*'
      }})
        .then(response => {
          return response.json();
        })
        .then(data => {
          fetchOrganisations(data)
        });
  } 

  useEffect(() => {
  getEmployeeData();
  getOrganisationData();
  }, []);

  const showEmployees = () => {
    updateShowEmployeeData(true);
  };

  const showOrganisations = () => {
    updateShowEmployeeData(false);
  };

  return (
    <div >
      <h2>Welcome to Demo App</h2>
      {showEmployeeData && (
         <div>
         <button onClick={showOrganisations}>Show Organisations Data</button>
         <Employees Employees = {EmployeeList}> </Employees> 
         </div>
      )}
      {!showEmployeeData && (
        <div>
        <button onClick={showEmployees}>Show Employees Data</button>
        <Organisations Organisations = {OrganisationList}> </Organisations> 
        </div>
      )}
     
    </div>
  );
}

export default App;
