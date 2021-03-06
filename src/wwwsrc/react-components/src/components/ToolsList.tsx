import * as React from 'react';

// tslint:disable-next-line:interface-name
interface Tool {
    id: string;
    name: string;
    templateUrlPath: string;
    json: string;
}

// tslint:disable-next-line:interface-name
interface Props {
    Tools: Tool[];
}

const renderToolListItem = (tool: Tool) => {
    const path = `${tool.templateUrlPath}/${tool.id}`;
    return (
        <li key={tool.id}>
            <a href={path}>{tool.name}</a>
        </li>
    );
};

function ToolsList({ Tools }: Props) {
    return (
        <div className='ToolsList'>
            <h2>Tools</h2>
            {Tools.map(renderToolListItem)}
        </div>
    );
}

export default ToolsList;
export { Tool }