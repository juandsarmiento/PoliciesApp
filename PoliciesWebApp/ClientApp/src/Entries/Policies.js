import React, { useEffect, useState } from 'react';
import ReactDOM from 'react-dom';
import { connect } from 'react-redux'
import { bindActionCreators } from 'redux';
import { Container } from 'reactstrap';
import PoliciesTable from '../components/PoliciesTable';
import Loading from '../components/Loading';
import { actionCreators } from '../reducers/policiesReducer'
import ModalYesNo from '../components/ModalYesNo';

const INITIAL_STATE = {
    modalIsOpen: false,
    policy: {}
};
const Policies = ({ policies, isLoading, actions }) => {
    const [policy2Del, setPolicy2Del] = useState({ ...INITIAL_STATE });

    useEffect(() => {
        const fetchData = async () => {
            actions.requestPolicies();
        }
        fetchData();
    }, [])

    const handleDelete = (policy) => {
        setPolicy2Del({
            modalIsOpen: true,
            policy
        })
    };
    const handleSubmit = async() => {
        actions.deletePolicy(policy2Del.policy.id);
        setPolicy2Del({...INITIAL_STATE});
    }
    if (isLoading) return <Loading />;
    return (
        <>
            <Container>
                <h6>Policies</h6>
                <PoliciesTable policies={policies} onDelete={handleDelete} />
            </Container>
        ReactDOM.createPortal(
            <ModalYesNo
                isOpen={policy2Del.modalIsOpen}
                header={`Delete ${policy2Del.policy.name}`}
                onClick={handleSubmit}
                onClose={() => setPolicy2Del({ ...INITIAL_STATE })}
            >
                Are you sure?
            </ModalYesNo>,
            document.getElementbyId('portal-root')
            )
        </>
    )
}

const mapState2Props = (state) => {
    const { policyState } = state;
    const policies = Object.values(policyState.policies)
    return {
        ...policyState,
        policies
    }
}
const mapDispatch2Props = (dispatch) => ({
    actions: bindActionCreators(actionCreators, dispatch)
})
export default connect(mapState2Props, mapDispatch2Props)(Policies)