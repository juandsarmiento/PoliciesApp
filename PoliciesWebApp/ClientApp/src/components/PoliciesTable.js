import React from 'react';
import { Table, Button } from 'reactstrap';
import { NavLink } from 'react-router-dom';
import { POLICIES_PATH } from './pathConstants';

const PoliciesTable = ({ policies, onDelete }) => (
    <Table id="policiesTable" bordered={true}>
        <thead>
            <tr>
                <th>Name</th>
                <th>Coverage(%)</th>
                <th>Coverage Time(Months)</th>
                <th>Delete</th>
                <th>Details</th>
            </tr>
        </thead>
        <tbody>
            {
                policies.map(p => (
                    <tr key={p.id}>
                        <td>{p.name}</td>
                        <td>{p.coverage}</td>
                        <td>{p.coverageTime}</td>
                        <td>
                            <Button className="btn btn-danger" onClick={() => onDelete(p)}>Delete</Button>
                        </td>
                        <td>
                            <NavLink className="btn btn-primary" to={`${POLICIES_PATH}/${p.id}`}>Edit</NavLink>
                        </td>
                    </tr>
                ))
            }
        </tbody>
    </Table>
)
export default PoliciesTable;