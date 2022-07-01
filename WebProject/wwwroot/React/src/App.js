import React, { useState, useEffect, Component } from 'react';
import axios from 'axios';
import ReactDOM from 'react-dom';
import PersonDetails from './PersonDetails';

function App() {
    const [people, setPersons] = useState([]);
    const APIUrl = '/React/GetPeopleList';

    useEffect(() => {
        getPeopleList();
    }, []);

    const getPeopleList = async () => {
        // Get the people from the database
        const res = await axios(
            APIUrl
        );

        // Sort them alphabetically
        const sortedPeople = res.data
            .sort(function (a, b) {
                if (a.name.toLowerCase() < b.name.toLowerCase()) return -1;
                if (a.name.toLowerCase() > b.name.toLowerCase()) return 1;
                return 0;
            });
        setPersons(sortedPeople);
    }

    return (
        <>
            <h1>People Table</h1>
            <table style={{ borderCollapse: "collapse" }}>
                <thead>
                    <tr>
                        <th style={{ border: "solid 1px black" }}>Name</th>
                        <th style={{ border: "solid 1px black" }}>ID</th>
                        <th style={{ border: "solid 1px black" }}>Display Details</th>
                    </tr>
                </thead>
                <tbody>
                    {people.map(p => {
                        return <tr key={p.id}>
                            <td key="name" style={{ border: "solid 1px black" }}>{p.name}</td>
                            <td key="id" style={{ border: "solid 1px black" }}>{p.id}</td>
                            {/* On click, get details for that specific person and then render the details component in the pre-designated field */}
                            <td key="details" onClick={() => {
                                axios.post('/React/GetPersonDetails', null, { params: { personID: p.id } })
                                    .then(res => {
                                        ReactDOM.render(<PersonDetails personName={res.data.name} id={res.data.id} city={res.data.city} country={res.data.country} ls={res.data.ls} />, document.querySelector("#details-container"));
                                    })
                            }} style={{ border: "solid 1px black", color:"blue" }}>Details</td>
                        </tr>
                    })
                    }
                </tbody>
            </table>

        </>
    );
}

export default App;