import React from 'react';
import { Button, Form, FormGroup, Label, Input } from 'reactstrap'

const checkChecked = (r,policyCoverageTypes =[]) => {
    if(policyCoverageTypes.findIndex(p => p === r.id) > -1){
        
        return true;
    }
    return false;
}
const FormPolicy = ({ policy,riskTypes, coverageTypes, onSubmit, onChange,toggleCheckBoxes }) => {

    const handleSubmit = (e) => {
        e.preventDefault();
        onSubmit();
    }
    const { name, coverage, coverageTime, policyCoverageTypes, startDate, price, riskId, description } = policy;

    return (<Form onSubmit={handleSubmit}>
        <FormGroup>
            <Label for="name" sm={2}>Name</Label>
            <Input name="name" value={name} onChange={onChange} />
        </FormGroup>
        <FormGroup>
            <Label for="coverage" sm={2}>Coverage</Label>
            <Input type="number" name="coverage" value={coverage} onChange={onChange} />
        </FormGroup>
        <FormGroup>
            <Label for="coverageTime" sm={2}>Coverage Time</Label>
            <Input type="number" name="coverageTime" value={coverageTime} onChange={onChange} />
        </FormGroup>
        <FormGroup>
            <Label for="startDate" sm={2}>Starting Date</Label>
            <Input type="date" name="startDate" value={startDate} onChange={onChange} />
        </FormGroup>
        <FormGroup>
            <Label for="price" sm={2}>Price</Label>
            <Input type="number" name="price" value={price} onChange={onChange} />
        </FormGroup>
        <FormGroup check>
            <Label sm={2}>Coverage Types</Label>
            <br/>
            {
                coverageTypes.map(r => (
                    <React.Fragment key={r.id} >
                        <Input type="checkbox" 
                            name='policyCoverageTypes' 
                            onChange={(e) => toggleCheckBoxes(e,r)}
                            checked={checkChecked(r,policyCoverageTypes)}  
                            />
                        {` ${r.name}`}
                        <br />
                    </React.Fragment>
                ))
            }
        </FormGroup>
        <FormGroup>
            <Label for="riskId" sm={2}>Risk</Label>
            <Input type="select" name="riskId" id="riskId" defaultValue={riskTypes[0].id} value={riskId} onChange={(e) => onChange(e,'number')}>
                {
                    riskTypes.map(r => (<option key={r.id} value={r.id}>{r.name}</option>))
                }
            </Input>
        </FormGroup>
        <FormGroup>
            <Label for="description" sm={2}>Descrip</Label>
            <Input type="textarea" name="description" id="description" value={description} onChange={onChange} />
        </FormGroup>
        <Button className='btn btn-primary'>Submit</Button>
    </Form>);
}

export default FormPolicy;