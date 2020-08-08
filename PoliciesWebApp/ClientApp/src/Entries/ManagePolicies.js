import React from 'react';
import { connect } from 'react-redux';
import { Container, Row } from 'reactstrap';
import CardClient from '../components/CardClient';
const ManagePolicies = ({ clients }) => {
    return (
    <Container>
        <p>Select a client</p>
        <Row className='justify-content-sm-center'>
            {
                clients.map(c => <CardClient client={c} cols={3}/>)
            }
        </Row>
    </Container>)
}

const mapState2Props = (state, ownProps) => {
    const { policyState } = state;
    const clients = Object.values(policyState.clients)
    return {
        clients
    }
}

export default connect(mapState2Props)(ManagePolicies);