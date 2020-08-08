import React, { useState } from 'react';
import { connect } from 'react-redux';
import moment from 'moment';
import FormPolicy from '../components/FormPolicy';
import { actionCreators } from '../reducers/policiesReducer'
import { bindActionCreators } from 'redux';
import Loading from '../components/Loading';

const EditPolicy = ({ isLoading, policy, riskTypes, coverageTypes, actions }) => {
    const [newPolicy, setNewPolicy] = useState(policy);
    const [titleName,setTitleName] = useState(policy.name);
    const handleChange = (e,type) => {
        const nextPolicyState = {
            ...newPolicy,
            [e.target.name]: (e.target.type === 'number' || type ==='number' )
                ? parseInt(e.target.value) : e.target.value
        };
        setNewPolicy(nextPolicyState);
        console.log(nextPolicyState)
    }
    const handleToggle = (e,r) => {
        const newCoverages = [...newPolicy.policyCoverageTypes]
        if(e.target.checked){
            newCoverages.push(r.id);
        }else{
            const index = newCoverages.findIndex(n => n === r.id);
            newCoverages.splice(index,1);
        }
        const newPolictyState = {
            ...newPolicy,
            policyCoverageTypes:newCoverages
        }
        setNewPolicy(newPolictyState);
        console.log(newPolictyState);
    }
    const handleSubmit = async () => {
        await actions.updatePolicy(newPolicy)
        setTitleName(newPolicy.name)
    }
    if (isLoading) return <Loading />;
    return (
        <>
            <h6>{`Edit Policy ${titleName}`}</h6>
            <FormPolicy 
                policy={newPolicy} 
                riskTypes={riskTypes} 
                coverageTypes={coverageTypes}
                onSubmit={handleSubmit}
                onChange={handleChange}
                toggleCheckBoxes={handleToggle}
            />
        </>
    )
}

const mapState2Props = (state,owpProps) => {
    const { policyState: { isLoading, riskTypes, coverageTypes,policies } } = state;
    const policy = 
    { 
        ...policies[owpProps.match.params.id],
        startDate:moment(policies[owpProps.match.params.id].startDate).format('yyyy-MM-DD')
    }
    return {
        isLoading,
        policy,
        riskTypes: Object.values(riskTypes),
        coverageTypes: Object.values(coverageTypes)
    }
}

const mapDispatch2Props = dispatch => ({
    actions: bindActionCreators(actionCreators, dispatch)
})
export default connect(mapState2Props, mapDispatch2Props)(EditPolicy);