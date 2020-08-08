import React, { useEffect } from 'react';
import { connect } from 'react-redux'
import { bindActionCreators } from 'redux';
import { Container } from 'reactstrap';
import Loading from '../components/Loading';
import { actionCreators } from '../reducers/policiesReducer'
import PolicyList from '../components/PolicyList';

const ManagePoliciesClient = ({ client, policies, isLoading }) => {
    useEffect(() => {
        const fetchData = async () => {
            alert('holamundo');
        }
        fetchData();
    }, [client.id])

    if (isLoading) return <Loading />;
    return (
        <Container>
            <h6>{client.name}</h6>
            <PolicyList policies={policies} />
        </Container>
    )
}

const mapState2Props = (state,ownProps) => {
    const { policyState } = state;
    const clientId = ownProps.match.params.id;
    const client = policyState.clients[clientId];
    const policies = client.policiesId(cId => policyState.policies[cId]);
    
    return {
        client,
        policies,
    }
}

const mapDispatch2Props = (dispatch) => ({
    actions: bindActionCreators(actionCreators, dispatch)
})
export default connect(mapState2Props, mapDispatch2Props)(ManagePoliciesClient)