import React from 'react';
import { Card, CardTitle, Col } from 'reactstrap';
import { NavLink } from 'react-router-dom';
import { CLIENT_PATH } from './pathConstants';

const CardClient = ({ client, cols = 6 }) => {
    return (
        <Col sm={cols}>
            <Card body>
                <CardTitle>{client.name}</CardTitle>
                <NavLink className="btn btn-primary"
                    to={`${CLIENT_PATH}/${client.id}`}>
                    Manage ManagePolicies
                    </NavLink>
            </Card>
        </Col>
    );
};

export default CardClient;