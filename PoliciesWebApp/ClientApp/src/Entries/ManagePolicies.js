import React from 'react';
import { connect } from 'react-redux';
import { Container, Row } from 'reactstrap';
import CardClient from '../components/CardClient';
const ManagePolicies = ({ clients }) => {

    const handleClick = (r) => {
        
    }
    return (
    <Container>
        <h6>Select a client</h6>
        <Row className='justify-content-sm-center'>
            {
                clients.map(c => <CardClient key={c.id} client={c} cols={3} onClick={handleClick}/>)
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