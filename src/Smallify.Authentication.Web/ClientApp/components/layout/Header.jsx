import React from 'react';
import styled from 'styled-components';

const Wrapper = styled.header`
  display: flex;
  justify-content: center;
  padding: 1rem;
`;

const Header = () => (
  <Wrapper>
    <svg baseProfile="full" width="256" height="256" viewBox="0 0 26.5 26.5" xmlns="http://www.w3.org/2000/svg">
      <g>
        <path d="M11.25729384.63571359c-5.8448578 0-10.5832703 4.7382883-10.5832703 10.5831462 0 5.845106 4.7384125 10.583017 10.5832703 10.583017 5.845484 0 10.583396-4.737911 10.583396-10.583017 0-5.8444806-4.737912-10.5826399-10.583525-10.5826399z" fill="#1ed760" />
        <path d="M14.52921884 14.56652879c-.133891.219582-.421308.289203-.640889.154421-1.755034-1.072014-3.964406-1.314803-6.566345-.720332-.2507299.05713-.5006602-.09997-.5577848-.350792-.057413-.250822.099077-.500749.3504358-.557875 2.847399-.650531 5.289832-.37043 7.260163.833689.21958.134786.289203.42131.15442.640889zm.914918-2.035313c-.168701.274207-.527528.360791-.801557.19209-2.009252-1.235007-5.072036-1.592671-7.4485947-.87127-.308215.0931-.6337456-.0806-.7272909-.388283-.092831-.308214.080962-.633124.3886391-.726846 2.7146735-.823696 6.0895155-.424702 8.3968945.993199.274028.168702.360611.52753.191909.801201zm.07854-2.119395c-2.409126-1.4309319-6.383864-1.5624359-8.6840365-.864398-.3693376.112086-.7599625-.096489-.8718917-.4658489-.1119359-.369536.096403-.759873.4660287-.872161 2.6404035-.8015576 6.9371675-.511939 9.7108415 1.134646 0 0 .520224.1734079.337187.8232769-.104626.37147-.626607.441751-.957762.244485z" fill="#000" />
        <path d="M16.30378684 16.15387879a7.1993776 7.1993776 0 10-.09411.09411l7.999307 7.99931m-4.281982-5.505408l5.176024 5.176024-1.223424 1.223421-5.176024-5.17602" fill="transparent" stroke="#000" strokeLinejoin="round" strokeLinecap="round" strokeWidth="1.36262369" />
      </g>
    </svg>
  </Wrapper>
);

export default Header;