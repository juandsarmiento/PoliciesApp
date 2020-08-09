import React from 'react';
import { ListGroup, ListGroupItem, Button } from 'reactstrap';
import {Col} from 'reactstrap';

const PolicyList = ({ policies, onClick, cols = 10 }) => (
    <Col cols={cols}>
        <ListGroup className='w-100'>
            {
                policies.map(p =>
                    <ListGroupItem key={p.id}>
                        {p.name}
                        <Button className='btn-danger float-right' onClick={() => onClick(p)}>
                            Cancel
                    </Button>
                    </ListGroupItem>)
            }
        </ListGroup>
    </Col>
)
export default PolicyList;