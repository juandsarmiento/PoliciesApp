import React, { useEffect } from 'react';
import ReactDOM from 'react-dom';
import { connect } from 'react-redux'
import { bindActionCreators } from 'redux';
import { Container, Row } from 'reactstrap';
import Loading from '../components/Loading';
import { actionCreators } from '../reducers/policiesReducer'
import PolicyList from '../components/PolicyList';
import ModalYesNo from '../components/ModalYesNo';
import AutocompletePolicies from '../components/AutocompletePolicies';
import { CLIENT_PATH } from '../components/pathConstants'

const ManagePoliciesClient = ({ client, policies, policy2Del, allPolicies, isLoading, modalIsOpen, history,actions }) => {
    useEffect(() => {
        const fetchData = async () => {

        }
        fetchData();
    }, [client.id])

    if (isLoading) return <Loading />;

    const handleSubmit = async () => {
        await actions.cancelPolicies(client.id,[policy2Del.id])
        await actions.requestClients();
        history.push(`${CLIENT_PATH}/${client.id}`)
    }
    const handleAdd = async (e,o) => {
        console.log(o);
        console.log(e);
        await actions.addPolicies(client.id,[o.id])
        await actions.requestClients();
    }
    return (
        <>
            <Container>
                <h6>{client.name}</h6>
                <Row>
                    <AutocompletePolicies cols={8} policies={allPolicies} onClick={handleAdd}/>
                </Row>
                <Row>
                    <PolicyList cols={10} policies={policies} onClick={(p) => history.push(`${CLIENT_PATH}/${client.id}/delete/${p.id}`)} />
                </Row>
            </Container>
            {
                ReactDOM.createPortal(
            <ModalYesNo
                isOpen={modalIsOpen}
                header={`Cancel ${policy2Del.name}`}
                onClick={handleSubmit}
                onClose={() => history.push(`${CLIENT_PATH}/${client.id}`)}
            >
                Are you sure?
                    </ModalYesNo>,
                    document.getElementById('portal-root')
                )
            }
        </>
    )
}

const mapState2Props = (state, ownProps) => {
    const { policyState } = state;
    const clientId = ownProps.match.params.id;
    const policyId = ownProps.match.params.policyId;
    const client = policyState.clients[clientId];
    const policies = client.policiesId.map(cId => policyState.policies[cId]);
    const allPolicies = Object.values(policyState.policies).filter(p =>  !client.policiesId.includes(p.id));
    const url = ownProps.match.path;

    return {
        client,
        policies,
        allPolicies,
        modalIsOpen: url === `${CLIENT_PATH}/:id/delete/:policyId` ? true : false,
        policy2Del: policyId ? policyState.policies[policyId]: {},
        history: ownProps.history,
    }
}

const mapDispatch2Props = (dispatch) => ({
    actions: bindActionCreators(actionCreators, dispatch)
})
export default connect(mapState2Props, mapDispatch2Props)(ManagePoliciesClient)